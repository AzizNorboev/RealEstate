using Entities.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Components.ApartmentTable
{
    public partial class ApartmentTable
    {
        [Parameter]
        public List<Apartment> Apartments { get; set; }
    }
}
