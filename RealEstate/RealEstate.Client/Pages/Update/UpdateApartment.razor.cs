using Entities.Models;
using Microsoft.AspNetCore.Components;
using RealEstate.Client.HttpRepository;
using RealEstate.Client.Shared;
using System.Threading.Tasks;

namespace RealEstate.Client.Pages.Update
{
    public partial class UpdateApartment
    {
        private Apartment _apartment;
        private SuccessNotification _notification;
        [Inject]
        IHttpRepository<Apartment> ApartmentRepo { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            _apartment = await ApartmentRepo.GetById(Id);
        }
        private async Task Update()
        {
            await ApartmentRepo.UpdateAsync(_apartment);
            _notification.Show();
        }
        private void AssignImageUrl(string imgUrl) => _apartment.ImageURL = imgUrl;
    }
}
