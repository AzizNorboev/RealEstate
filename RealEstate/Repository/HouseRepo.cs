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
    public class HouseRepo : RepositoryBase, IRepositoryBase<House>
    {

        public HouseRepo(RepoContext context)
            : base(context)
        {
        }

        //public async Task<IEnumerable<House>> GetHouses()
        //{
        //   return await _context.Houses.ToListAsync();
        //}

        public async Task CreateAsync(House house)
        {
            _context.Add(house);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var house = await _context.Houses.FindAsync(id);
            _context.Houses.Remove(house);
            await _context.SaveChangesAsync();
        }

    

        public async Task<PagedList<House>> GetAllAsync(EntityParameters entityParameters)
        {
            var houses = await _context.Houses
                .Include(h => h.Region)
             .Search(entityParameters.SearchTerm)
             .Sort(entityParameters.OrderBy)
             .ToListAsync();

            return PagedList<House>
                .ToPagedList(houses, entityParameters.PageNumber, entityParameters.PageSize);
        }

        public async Task<House> GetByIdAsync(int id)
        {
            return await _context.Houses
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task UpdateAsync(House entity, House dbHouse)
        {
            dbHouse.Description = entity.Description;
            
            dbHouse.ImageURL = entity.ImageURL;
            dbHouse.NumOfRooms = entity.NumOfRooms;
            dbHouse.Price = entity.Price;
            dbHouse.RegionId = entity.RegionId;
            dbHouse.Square = entity.Square;
            dbHouse.Status = entity.Status;


            await _context.SaveChangesAsync();
            await _context.SaveChangesAsync();
        }
    }
}
