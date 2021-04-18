using Entities.Models;
using Microsoft.AspNetCore.Components;
using RealEstate.Client.HttpRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Pages.Details
{
    public partial class RegionDetails
    {
        private Region _region;
        
        [Inject]
        IHttpRepository<Region> RegionRepo { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            _region = await RegionRepo.GetById(Id);
        }
    }
}
