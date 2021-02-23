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

        [Inject]
        public IPropertyHttpRepository<House> HouseRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await GetProperty();
           
        }

        private async Task SelectedPage(int page)
        {
            _houseParameters.PageNumber = page;
            await GetProperty();
        }
        private async Task GetProperty()
        {
            var pagingResponse = await HouseRepo.GetProperty(_houseParameters);
            HouseList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }

        private async Task SearchChanged(string searchTerm)
        {
            Console.WriteLine(searchTerm);
            _houseParameters.PageNumber = 1;
            _houseParameters.SearchTerm = searchTerm;
            await GetProperty();
        }

        private async Task SortChanged(string orderBy)
        {
            Console.WriteLine(orderBy);
            _houseParameters.OrderBy = orderBy;
            await GetProperty();
        }
    }
}
