using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Extentions
{
    public static class ServiceExtentions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(policy =>
            {
                policy.AddPolicy("CorsPolicy", opt => opt
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .WithExposedHeaders("X-Pagination"));
            });
        }

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepoContext>(
               options => options.UseSqlServer(
                   configuration.GetConnectionString("RealEstateWADcw")
                   )
               );
        }

        public static void ConfigureDI(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Apartment>, ApartmentRepo>();
            services.AddScoped<IRepository<House>, HouseRepo>();
            services.AddScoped<IRepository<Region>, RegionRepo>();
        }

        /// <summary>
        /// to display data from different tables
        /// </summary>
        /// <param name="services"></param>
        public static void AddNewTonSoftJson(this IServiceCollection services)
        {
            services.AddControllersWithViews()
                    .AddNewtonsoftJson(options =>
                      options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                   );
        }
    }
}
