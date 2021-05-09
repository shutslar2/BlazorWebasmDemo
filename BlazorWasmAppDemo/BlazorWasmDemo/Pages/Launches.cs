using BlazorWasmDemo.DataServices;
using BlazorWasmDemo.Dtos;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmDemo.Pages
{
    public partial class Launches
    {
        [Inject]
        ISpaceXDataService SpaceXDataService { get; set; }

        private List<LaunchesDto> launches;
        protected override async Task OnInitializedAsync()
        {
            launches = await SpaceXDataService.GetAllLaunches();
        }
    }
}
