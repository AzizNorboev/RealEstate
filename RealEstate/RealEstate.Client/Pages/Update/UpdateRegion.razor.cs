using Entities.Models;
using Microsoft.AspNetCore.Components;
using RealEstate.Client.HttpRepository;
using RealEstate.Client.Shared;
using System.Threading.Tasks;

namespace RealEstate.Client.Pages.Update
{
    public partial class UpdateRegion
    {
        private Region _region;
        private SuccessNotification _notification;
        [Inject]
        IHttpRepository<Region> RegionRepo { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            _region = await RegionRepo.GetById(Id);
        }
        private async Task Update()
        {
            await RegionRepo.UpdateAsync(_region);
            _notification.Show();
        }
    }
}
