using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Entities.Models;
using RealEstate.Client.HttpRepository;
using Tewr.Blazor.FileReader;

namespace RealEstate.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IPropertyHttpRepository<Apartment>, ApartmentHttpRepository>();
            builder.Services.AddScoped<IPropertyHttpRepository<House>, HouseHttpRepository>();
            builder.Services.AddScoped<IPropertyHttpRepository<Region>, RegionHttpRepository>();
            builder.Services.AddFileReaderService(o => o.UseWasmSharedBuffer = true);
            await builder.Build().RunAsync();
        }
    }
}
