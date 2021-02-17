using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task CreateAsync(Apartment entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var apartment = await _context.Apartments.FindAsync(id);
            _context.Apartments.Remove(apartment);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Apartment>> GetAllAsync()
        {
            return await _context.Apartments.ToListAsync();
        }

        public async Task<Apartment> GetByIdAsync(int id)
        {
            return await _context.Apartments
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task UpdateAsync(Apartment entity)
        {
             _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
