using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
