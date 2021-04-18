using Entities.Models;
using Microsoft.AspNetCore.Components;
using RealEstate.Client.HttpRepository;
using RealEstate.Client.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Pages.Create
{
    public partial class CreateApartment
    {
        private readonly Apartment _apartment = new Apartment();

        private SuccessNotification _notification;

        [Inject]
        public IHttpRepository<Apartment> ApartmentRepo { get; set; }
        //TODO: Region should be chosen not inserted by user
        private async Task Create()
        {
            await ApartmentRepo.CreateAsync(_apartment);
            _notification.Show();
        }
        private void AssignImageUrl(string imgUrl) => _apartment.ImageURL = imgUrl;

    }
}
