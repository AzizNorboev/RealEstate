using Entities;
using Entities.Features;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Extentions;
using Repository.Pagination;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ApartmentRepo : RepositoryBase, IRepositoryBase<Apartment>
    {
        

        public ApartmentRepo(RepoContext context)
            : base(context)
        {
        }

        public async Task CreateAsync(Apartment apartment)
        {
            _context.Add(apartment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var apartment = await _context.Apartments.FindAsync(id);
            _context.Apartments.Remove(apartment);
            await _context.SaveChangesAsync();
        }

        //public async Task<IEnumerable<Apartment>> GetAllAsync()
        //{
        //    return await _context.Apartments.ToListAsync();
        //}

        public async Task<PagedList<Apartment>> GetAllAsync(EntityParameters entityParameters)
        {

            var apartments = await _context.Apartments
                //.Include(a => a.Region)
              .Search(entityParameters.SearchTerm)
              .Sort(entityParameters.OrderBy)
              .ToListAsync();

            //var apartments = await _context.Apartments.ToListAsync();

            return PagedList<Apartment>
                .ToPagedList(apartments, entityParameters.PageNumber, entityParameters.PageSize);
        }

        public async Task<Apartment> GetByIdAsync(int id)
        {
            return await _context.Apartments
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task UpdateAsync(Apartment apartment, Apartment dbApartment)
        {

            dbApartment.Description = apartment.Description;
            dbApartment.FloorNo = apartment.FloorNo;
            dbApartment.ImageURL = apartment.ImageURL;
            dbApartment.NumOfRooms = apartment.NumOfRooms;
            dbApartment.Price = apartment.Price;
            dbApartment.RegionId = apartment.RegionId;
            dbApartment.Square = apartment.Square;
            dbApartment.Status = apartment.Status;

            
            await _context.SaveChangesAsync();
        }
    }
}
