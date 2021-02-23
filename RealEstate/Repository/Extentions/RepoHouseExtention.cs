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
        public static IQueryable<House> Search(this IQueryable<House> houses, string searchTearm)
        {
            if (string.IsNullOrWhiteSpace(searchTearm))
                return houses;
            var lowerCaseSearchTerm = searchTearm.Trim().ToLower();
            return houses.Where(h => h.Description.ToLower().Contains(lowerCaseSearchTerm));
        }

        public static IQueryable<House> Sort(this IQueryable<House> houses, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return houses.OrderBy(e => e.Status);

            var orderParams = orderByQueryString.Trim().Split(',');
            var propertyInfos = typeof(House).GetProperties(BindingFlags.Public | BindingFlags.Instance);
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
                return houses.OrderBy(e => e.Status);

            return houses.OrderBy(orderQuery);
        }
    }
}
