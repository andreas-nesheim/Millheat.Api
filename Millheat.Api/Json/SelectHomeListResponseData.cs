using System.Text.Json.Serialization;

namespace Millheat.Api.Json
{
    internal class SelectHomeListResponseData
    {
        [JsonPropertyName("homeList")]
        public Home[] Homes { get; set; }
    }
}
