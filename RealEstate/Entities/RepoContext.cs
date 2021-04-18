using Entities.Configuration;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
namespace Entities
{
    public class RepoContext : DbContext
    {
        public RepoContext(DbContextOptions<RepoContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
        //to keep this method/class clean and readable
        //there were created serveral configuration classes
        //with code to insert default data to the db
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RegionConfiguration());
            modelBuilder.ApplyConfiguration(new ApartmentConfiguration());
            modelBuilder.ApplyConfiguration(new HouseConfiguration());

        }

        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<House> Houses { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
    }
}
