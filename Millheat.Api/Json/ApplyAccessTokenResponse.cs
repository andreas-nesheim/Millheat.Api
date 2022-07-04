using System.Text.Json.Serialization;

namespace Millheat.Api.Json
{
    internal class ApplyAccessTokenResponse : BaseResponse
    {
        [JsonPropertyName("data")]
        public ApplyAccessTokenResponseData Data { get; set; }
    }
}
