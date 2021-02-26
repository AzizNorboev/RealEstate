using Entities.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.Components.HouseTable
{
    public partial class HouseTable
    {
        [Parameter]
        public List<House> Houses { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private void RedirectToUpdate(int id)
        {
            var url = Path.Combine("/updateHouse/", id.ToString());
            NavigationManager.NavigateTo(url);
        }
        

        [Parameter]
        public EventCallback<int> OnDeleted { get; set; }

        //JS invoke 
        [Inject]
        public IJSRuntime Js { get; set; }

        private async Task Delete(int id)
        {
            var house = Houses.FirstOrDefault(p => p.Id.Equals(id));

            var confirmed = await Js.InvokeAsync<bool>("confirm", $"Are you sure you want to delete the house with Id: {house.Id}?");
            if (confirmed)
            {
                await OnDeleted.InvokeAsync(id);
            }
        }
    }
}
