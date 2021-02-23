using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
