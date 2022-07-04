using System.Text.Json.Serialization;

namespace Millheat.Api.Json
{
    internal class SelectHomeListResponse : BaseResponse
    {
        [JsonPropertyName("data")]
        public SelectHomeListResponseData Data { get; set; }
    }
}
