using BlazorWasmDemo.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorWasmDemo.DataServices
{
    public class GraphQlSpaceXDataService : ISpaceXDataService
    {
        private readonly HttpClient _httpClient;

        public GraphQlSpaceXDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<LaunchesDto>> GetAllLaunches()
        {
            var GqlQuery = new {
                query = @"{launches{id is_tentative launch_date_local mission_name upcoming details}}",
                variables = new {}
            };

            var LaunchQuery = new StringContent(
                JsonSerializer.Serialize(GqlQuery),
                Encoding.UTF8,
                "application/json");

            var response = await _httpClient.PostAsync("graphql",LaunchQuery);

            if (response.IsSuccessStatusCode)
            {
                var gqlData = await JsonSerializer.DeserializeAsync<GqlData>
                    (await response.Content.ReadAsStreamAsync());

                return gqlData.Data.Launches;
            }

            return null;    // TODO: What should we return instead of null?
        }
    }
}
