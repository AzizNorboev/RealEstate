using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task CreateAsync(House entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var house = await _context.Houses.FindAsync(id);
            _context.Houses.Remove(house);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<House>> GetAllAsync()
        {
            return await _context.Houses.ToListAsync();
        }

        public async Task<House> GetByIdAsync(int id)
        {
            return await _context.Houses
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task UpdateAsync(House entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
