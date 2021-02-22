using Entities.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Components.HouseTable
{
    public partial class HouseTable
    {
        [Parameter]
        public List<House> Houses { get; set; }
    }
}
