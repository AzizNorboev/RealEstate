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
    public partial class Houses
    {
        public List<House> HouseList { get; set; } = new List<House>();
        public MetaData MetaData { get; set; } = new MetaData();
        private EntityParameters _productParameters = new EntityParameters();

        [Inject]
        public IPropertyHttpRepository<House> HouseRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            var pagingResponse = await HouseRepo.GetProperty(_productParameters);
            HouseList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
    }
}
