using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RegionRepo : RepositoryBase, IRepositoryBase<Region>
    {
        public RegionRepo(RepoContext context)
            : base(context)
        {
        }

        public async Task CreateAsync(Region entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var region = await _context.Regions.FindAsync(id);
            _context.Regions.Remove(region);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Region>> GetAllAsync()
        {
            return await _context.Regions.ToListAsync();
        }

        public async Task<Region> GetByIdAsync(int id)
        {
            return await _context.Regions
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task UpdateAsync(Region entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

    }
}
