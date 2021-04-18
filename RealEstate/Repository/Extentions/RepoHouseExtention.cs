using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Linq.Dynamic.Core;

namespace Repository.Extentions
{
    public static class RepoHouseExtention
    {
        //first check if the parameter is actually sent
        //then using Where clause to specify from which attribute to search
        public static IQueryable<House> Search(this IQueryable<House> houses, string searchTearm)
        {
            if (string.IsNullOrWhiteSpace(searchTearm))
                return houses;
            var lowerCaseSearchTerm = searchTearm.Trim().ToLower();
            return houses.Where(h => h.Description.ToLower().Contains(lowerCaseSearchTerm));
        }

        //this method has 2 arguments, one for list of entities and another for ordering query
        public static IQueryable<House> Sort(this IQueryable<House> houses, string orderByQueryString)
        {
            //if there's no entity we exit the method
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return houses.OrderBy(e => e.Status);

            //splitting the query string to get individual fields 
            var orderParams = orderByQueryString.Trim().Split(',');

            //we need property info to be able to check if the field recieved via the query string
            // infact exsists in the house class
            var propertyInfos = typeof(House).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var orderQueryBuilder = new StringBuilder();

            foreach (var param in orderParams)
            {
                //we  run through all the parameters and check for their existence
                if (string.IsNullOrWhiteSpace(param))
                    continue;

                var propertyFromQueryName = param.Split(" ")[0];
                var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

                //If we don’t find such a property we skip the step and 
                //go to the next parameter in the list
                if (objectProperty == null)
                    continue;

                //when a parameter returned, we check if it contains 'desc' at the end of the string
                var direction = param.EndsWith(" desc") ? "descending" : "ascending";

                //using StringBuilder to build our query with each loop
                orderQueryBuilder.Append($"{objectProperty.Name} {direction}, ");
            }
            //after looping trough all the fields, it is removing excess commas
            //and doing the last check if query actually has something in it
            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');
            if (string.IsNullOrWhiteSpace(orderQuery))
                return houses.OrderBy(e => e.Status);

            return houses.OrderBy(orderQuery);
        }
    }
}
