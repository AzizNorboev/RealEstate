using Entities.Models;
using Microsoft.AspNetCore.Components;
using RealEstate.Client.HttpRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Pages
{
    public partial class Apartments
    {
        public List<Apartment> ApartmentList { get; set; } = new List<Apartment>();

        [Inject]
        public IPropertyHttpRepository<Apartment> ApartmentRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {
            ApartmentList = await ApartmentRepo.GetProperty();

            //just for testing
            //foreach (var apartment in ApartmentList)
            //{
            //    Console.WriteLine(apartment.ImageURL);
            //}
        }
    }
}
