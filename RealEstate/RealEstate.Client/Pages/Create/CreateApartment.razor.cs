using Entities.Models;
using Microsoft.AspNetCore.Components;
using RealEstate.Client.HttpRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Pages.Create
{
    public partial class CreateApartment
    {
        private readonly Apartment _apartment = new Apartment();

        [Inject]
        public IPropertyHttpRepository<Apartment> ApartmentRepo { get; set; }

        private async Task Create()
        {
            await ApartmentRepo.CreateAsync(_apartment);
        }
    }
}
