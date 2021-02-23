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

        [Inject]
        public IPropertyHttpRepository<Region> RegionRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await GetProperty();
           
        }

        private async Task SelectedPage(int page)
        {
            _regionParameters.PageNumber = page;
            await GetProperty();
        }
        private async Task GetProperty()
        {
            var pagingResponse = await RegionRepo.GetProperty(_regionParameters);
            RegionList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
    }
}
