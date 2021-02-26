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
    public partial class UpdateApartment
    {
        private Apartment _apartment;
        private SuccessNotification _notification;
        [Inject]
        IPropertyHttpRepository<Apartment> ApartmentRepo { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            _apartment = await ApartmentRepo.GetPropertyById(Id);
        }
        private async Task Update()
        {
            await ApartmentRepo.UpdateProperty(_apartment);
            _notification.Show();
        }
    }
}
