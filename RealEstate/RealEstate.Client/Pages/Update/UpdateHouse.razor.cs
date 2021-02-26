using Entities.Models;
using Microsoft.AspNetCore.Components;
using RealEstate.Client.HttpRepository;
using RealEstate.Client.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Pages.Update
{
    public partial class UpdateHouse
    {
        private House _house;
        private SuccessNotification _notification;
        [Inject]
        IPropertyHttpRepository<House> HouseRepo { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            _house = await HouseRepo.GetPropertyById(Id);
        }
        private async Task Update()
        {
            await HouseRepo.UpdateProperty(_house);
            _notification.Show();
        }
    }
}
