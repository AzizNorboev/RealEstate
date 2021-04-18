using Entities.Models;
using Microsoft.AspNetCore.Components;
using RealEstate.Client.HttpRepository;
using RealEstate.Client.Shared;
using System.Threading.Tasks;

namespace RealEstate.Client.Pages.Update
{
    public partial class UpdateHouse
    {
        private House _house;
        private SuccessNotification _notification;
        [Inject]
        IHttpRepository<House> HouseRepo { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            _house = await HouseRepo.GetById(Id);
        }
        private async Task Update()
        {
            await HouseRepo.UpdateAsync(_house);
            _notification.Show();
        }
        private void AssignImageUrl(string imgUrl) => _house.ImageURL = imgUrl;
    }
}
