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
        private EntityParameters _productParameters = new EntityParameters();

        [Inject]
        public IPropertyHttpRepository<Region> RegionRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            var pagingResponse = await RegionRepo.GetProperty(_productParameters);
            RegionList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
    }
}
