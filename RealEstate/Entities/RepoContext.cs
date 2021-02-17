using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepoContext : DbContext
    {
        public RepoContext(DbContextOptions<RepoContext> options)
            :base(options)
        {

        }
        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<House> Houses { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
    }
}
