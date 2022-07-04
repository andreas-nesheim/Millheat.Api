using System.Text.Json.Serialization;

namespace Millheat.Api.Json
{
    internal class ApplyAuthCodeResponse : BaseResponse
    {
        [JsonPropertyName("data")]
        public ApplyAuthCodeResponseData Data { get; set; }
    }
}
