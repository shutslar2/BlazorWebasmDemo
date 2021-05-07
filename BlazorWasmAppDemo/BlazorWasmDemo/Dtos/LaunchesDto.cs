using System;
using System.Text.Json.Serialization;

namespace BlazorWasmDemo.Dtos
{
    public partial class LaunchesDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("is_tentative")]
        public bool IsTentative { get; set; }

        [JsonPropertyName("launch_date_local")]
        public DateTimeOffset LaunchDateLocal { get; set; }

        [JsonPropertyName("mission_name")]
        public string MissionName { get; set; }

        [JsonPropertyName("upcoming")]
        public bool Upcoming { get; set; }

        [JsonPropertyName("details")]
        public string Details { get; set; }
    }
}
