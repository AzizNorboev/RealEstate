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
    public class ApartmentRepo : RepositoryBase, IRepository<Apartment>
    {


        public ApartmentRepo(RepoContext context)
            : base(context)
        {
        }

        public async Task Create(Apartment entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Apartment entity, Apartment dbEntity)
        {
            dbEntity.Description = entity.Description;
            dbEntity.FloorNo     = entity.FloorNo;
            dbEntity.ImageURL    = entity.ImageURL;
            dbEntity.NumOfRooms  = entity.NumOfRooms;
            dbEntity.Price       = entity.Price;
            dbEntity.RegionId    = entity.RegionId;
            dbEntity.Square      = entity.Square;
            dbEntity.Status      = entity.Status;


            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var apartment = await _context.Apartments.FindAsync(id);
            _context.Apartments.Remove(apartment);
            await _context.SaveChangesAsync();
        }


        public async Task<Apartment> GetById(int id)
        {
            return await _context.Apartments
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<PagedList<Apartment>> GetAll(EntityParameters entityParameters)
        {
            var apartments = await _context.Apartments
              .Include(a => a.Region)
             .Search(entityParameters.SearchTerm)
             .Sort(entityParameters.OrderBy)
             .ToListAsync();


            return PagedList<Apartment>
                .ToPagedList(apartments, entityParameters.PageNumber, entityParameters.PageSize);
        }

    }
}
