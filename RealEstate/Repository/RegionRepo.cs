using Entities;
using Entities.Features;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Pagination;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RegionRepo : RepositoryBase, IRepository<Region>
    {
        public RegionRepo(RepoContext context)
            : base(context)
        {
        }

        public async Task Create(Region entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Region entity, Region dbEntity)
        {
            dbEntity.Name = entity.Name;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var region = await _context.Regions.FindAsync(id);
            _context.Regions.Remove(region);
            await _context.SaveChangesAsync();
        }

        public async Task<PagedList<Region>> GetAll(EntityParameters entityParameters)
        {
            var regions = await _context.Regions.ToListAsync();

            return PagedList<Region>
                .ToPagedList(regions, entityParameters.PageNumber, entityParameters.PageSize);
        }

        public async Task<Region> GetById(int id)
        {
            return await _context.Regions
                .FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
