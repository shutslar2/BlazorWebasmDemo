using BlazorWasmDemo.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorWasmDemo.DataServices
{
    public class RestSpaceXDataService : ISpaceXDataService
    {
        private readonly HttpClient _httpClient;

        public RestSpaceXDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<LaunchesDto>> GetAllLaunches()
        {
            return await _httpClient.GetFromJsonAsync<List<LaunchesDto>>("/rest/launches");
        }
    }
}
