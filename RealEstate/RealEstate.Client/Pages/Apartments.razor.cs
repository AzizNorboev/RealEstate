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
        private EntityParameters _apartmentParameters = new EntityParameters();

        [Inject]
        public IPropertyHttpRepository<Apartment> ApartmentRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await GetProperty();
        }

        private async Task SelectedPage(int page)
        {
            _apartmentParameters.PageNumber = page;
            await GetProperty();
        }
        private async Task GetProperty()
        {
            var pagingResponse = await ApartmentRepo.GetProperty(_apartmentParameters);
            ApartmentList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }

        private async Task SearchChanged(string searchTerm)
        {
            Console.WriteLine(searchTerm);
            _apartmentParameters.PageNumber = 1;
            _apartmentParameters.SearchTerm = searchTerm;
            await GetProperty();
        }

        private async Task SortChanged(string orderBy)
        {
            Console.WriteLine(orderBy);
            _apartmentParameters.OrderBy = orderBy;
            await GetProperty();
        }

        private async Task DeleteApartment(int id)
        {
            await ApartmentRepo.DeleteProperty(id);
            _apartmentParameters.PageNumber = 1;
            await GetProperty();
        }
    }
}
