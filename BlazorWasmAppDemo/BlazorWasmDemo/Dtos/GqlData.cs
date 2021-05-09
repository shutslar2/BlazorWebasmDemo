using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorWasmDemo.Dtos
{
    public partial class GqlData
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonPropertyName("launches")]
        public List<LaunchesDto> Launches { get; set; }
    }
}
