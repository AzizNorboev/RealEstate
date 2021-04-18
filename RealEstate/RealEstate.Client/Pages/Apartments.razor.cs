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

        [Inject]//we are injectiong the interface to call the GetAll method
        public IHttpRepository<Apartment> ApartmentRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await GetAll();

        }

        private async Task SelectedPage(int page)
        {
            _apartmentParameters.PageNumber = page;
            await GetAll();
        }
        private async Task GetAll()
        {
            var pagingResponse = await ApartmentRepo.GetAll(_apartmentParameters);
            ApartmentList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }

        private async Task SearchChanged(string searchTerm)
        {
            Console.WriteLine(searchTerm);
            _apartmentParameters.PageNumber = 1;
            _apartmentParameters.SearchTerm = searchTerm;
            await GetAll();
        }

        private async Task SortChanged(string orderBy)
        {
            Console.WriteLine(orderBy);
            _apartmentParameters.OrderBy = orderBy;
            await GetAll();
        }

        private async Task DeleteApartment(int id)
        {
            await ApartmentRepo.DeleteAsync(id);
            _apartmentParameters.PageNumber = 1;
            await GetAll();
        }
    }
}
