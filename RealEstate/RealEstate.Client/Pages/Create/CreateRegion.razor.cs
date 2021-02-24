using Entities.Models;
using Microsoft.AspNetCore.Components;
using RealEstate.Client.HttpRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Pages.Create
{
    public partial class CreateRegion
    {
        private readonly Region _region = new Region();

        [Inject]
        public IPropertyHttpRepository<Region> RegionRepo { get; set; }

        private async Task Create()
        {
            await RegionRepo.CreateAsync(_region);
        }
    }
}
