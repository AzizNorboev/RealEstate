using Entities.Features;
using Entities.Models;
using Microsoft.AspNetCore.Components;
using RealEstate.Client.HttpRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Pages
{
    public partial class Regions
    {
        public List<Region> RegionList { get; set; } = new List<Region>();
        public MetaData MetaData { get; set; } = new MetaData();
        private EntityParameters _regionParameters = new EntityParameters();

        [Inject]//we are injectiong the interface to call the GetAll method
        public IHttpRepository<Region> RegionRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await GetAll();

        }

        private async Task SelectedPage(int page)
        {
            _regionParameters.PageNumber = page;
            await GetAll();
        }
        private async Task GetAll()
        {
            var pagingResponse = await RegionRepo.GetAll(_regionParameters);
            RegionList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }

        private async Task DeleteRegion(int id)
        {
            await RegionRepo.DeleteAsync(id);
            _regionParameters.PageNumber = 1;
            await GetAll();
        }
    }
}
