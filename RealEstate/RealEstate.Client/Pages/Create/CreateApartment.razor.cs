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
        //private readonly Region _region = new Region();
        private SuccessNotification _notification;

        [Inject]
        public IPropertyHttpRepository<Apartment> ApartmentRepo { get; set; }
        //TODO: Region should be chosen not inserted by user
        private async Task Create()
        {
            await ApartmentRepo.CreateAsync(_apartment);
            _notification.Show();
        }
       
    }
}
