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
        private EntityParameters _houseParameters = new EntityParameters();

        [Inject]//we are injectiong the interface to call the GetAll method
        public IHttpRepository<House> HouseRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
           await GetAll();

        }

        private async Task SelectedPage(int page)
        {
            _houseParameters.PageNumber = page;
            await GetAll();
        }
        private async Task GetAll()
        {
            var pagingResponse = await HouseRepo.GetAll(_houseParameters);
            HouseList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }

        private async Task SearchChanged(string searchTerm)
        {
            Console.WriteLine(searchTerm);
            _houseParameters.PageNumber = 1;
            _houseParameters.SearchTerm = searchTerm;
            await GetAll();
        }

        private async Task SortChanged(string orderBy)
        {
            Console.WriteLine(orderBy);
            _houseParameters.OrderBy = orderBy;
            await GetAll();
        }

        private async Task DeleteHouse(int id)
        {
            await HouseRepo.DeleteAsync(id);
            _houseParameters.PageNumber = 1;
            await GetAll();
        }
    }
}
