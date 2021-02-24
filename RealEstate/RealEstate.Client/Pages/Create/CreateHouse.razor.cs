using Entities.Models;
using Microsoft.AspNetCore.Components;
using RealEstate.Client.HttpRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Pages.Create
{
    public partial class CreateHouse
    {
        private readonly House _house= new House();

        [Inject]
        public IPropertyHttpRepository<House> HouseRepo { get; set; }

        private async Task Create()
        {
            await HouseRepo.CreateAsync(_house);
        }
    }
}
