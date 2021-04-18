using Entities.Models;
using Microsoft.AspNetCore.Components;
using RealEstate.Client.HttpRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Pages.Details
{
    public partial class HouseDetails
    {
        private House _house;

        [Inject]
        IHttpRepository<House> HouseRepo { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            _house = await HouseRepo.GetById(Id);
        }
    }
}
