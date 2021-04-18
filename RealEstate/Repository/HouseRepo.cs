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
    public class HouseRepo : RepositoryBase, IRepository<House>
    {

        public HouseRepo(RepoContext context)
            : base(context)
        {
        }

        public async Task Create(House entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(House entity, House dbEntity)
        {
            dbEntity.Description = entity.Description;
            dbEntity.ImageURL = entity.ImageURL;
            dbEntity.NumOfRooms = entity.NumOfRooms;
            dbEntity.Price = entity.Price;
            dbEntity.RegionId = entity.RegionId;
            dbEntity.Square = entity.Square;
            dbEntity.Status = entity.Status;


            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var house = await _context.Houses.FindAsync(id);
            _context.Houses.Remove(house);
            await _context.SaveChangesAsync();
        }

        public async Task<PagedList<House>> GetAll(EntityParameters entityParameters)
        {
            var houses = await _context.Houses
               .Include(h => h.Region)
            .Search(entityParameters.SearchTerm)
            .Sort(entityParameters.OrderBy)
            .ToListAsync();


            return PagedList<House>
                .ToPagedList(houses, entityParameters.PageNumber, entityParameters.PageSize);
        }

        public async Task<House> GetById(int id)
        {
            return await _context.Houses
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
