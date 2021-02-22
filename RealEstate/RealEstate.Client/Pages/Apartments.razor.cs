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
    public partial class Apartments
    {
        public List<Apartment> ApartmentList { get; set; } = new List<Apartment>();
        public MetaData MetaData { get; set; } = new MetaData();
        private EntityParameters _productParameters = new EntityParameters();

        [Inject]
        public IPropertyHttpRepository<Apartment> ApartmentRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            var pagingResponse = await ApartmentRepo.GetProperty(_productParameters);
            ApartmentList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
    }
}
