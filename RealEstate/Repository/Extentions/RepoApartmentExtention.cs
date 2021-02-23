using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Linq.Dynamic.Core;

namespace Repository.Extentions
{
    public static class RepoApartmentExtention
    {
        public static IQueryable<Apartment> Search(this IQueryable<Apartment> apartments, string searchTearm)
        {
            if (string.IsNullOrWhiteSpace(searchTearm))
                return apartments;
            var lowerCaseSearchTerm = searchTearm.Trim().ToLower();
            return apartments.Where(p => p.Description.ToLower().Contains(lowerCaseSearchTerm));
        }

        public static IQueryable<Apartment> Sort(this IQueryable<Apartment> apartments, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return apartments.OrderBy(e => e.Status);

            var orderParams = orderByQueryString.Trim().Split(',');
            var propertyInfos = typeof(Apartment).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var orderQueryBuilder = new StringBuilder();

            foreach (var param in orderParams)
            {
                if (string.IsNullOrWhiteSpace(param))
                    continue;

                var propertyFromQueryName = param.Split(" ")[0];
                var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

                if (objectProperty == null)
                    continue;

                var direction = param.EndsWith(" desc") ? "descending" : "ascending";
                orderQueryBuilder.Append($"{objectProperty.Name} {direction}, ");
            }

            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');
            if (string.IsNullOrWhiteSpace(orderQuery))
                return apartments.OrderBy(e => e.Status);

            return apartments.OrderBy(orderQuery);
        }

      
    }
}
