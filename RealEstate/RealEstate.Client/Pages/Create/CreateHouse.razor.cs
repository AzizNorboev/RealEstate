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
    public partial class CreateHouse
    {
        private readonly House _house= new House();

        private SuccessNotification _notification;

        [Inject]
        public IHttpRepository<House> HouseRepo { get; set; }

        private async Task Create()
        {
            await HouseRepo.CreateAsync(_house);
            _notification.Show();

        }
        private void AssignImageUrl(string imgUrl) => _house.ImageURL = imgUrl;
    }
}