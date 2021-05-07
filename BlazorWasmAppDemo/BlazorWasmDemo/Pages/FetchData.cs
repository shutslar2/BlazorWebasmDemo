using BlazorWasmDemo.Dtos;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorWasmDemo.Pages
{
    public partial class FetchData
    {
        [Inject]
        private HttpClient Http {get; set; }

        private List<LaunchesDto> launches;

        protected override async Task OnInitializedAsync()
        {
            launches = await Http.GetFromJsonAsync<List<LaunchesDto>>("/rest/launches");
        }

    }
}
