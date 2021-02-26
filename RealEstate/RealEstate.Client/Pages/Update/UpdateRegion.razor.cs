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
    public partial class UpdateRegion
    {
        private Region _region;
        private SuccessNotification _notification;
        [Inject]
        IPropertyHttpRepository<Region> RegionRepo { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            _region = await RegionRepo.GetPropertyById(Id);
        }
        private async Task Update()
        {
            await RegionRepo.UpdateProperty(_region);
            _notification.Show();
        }
    }
}
