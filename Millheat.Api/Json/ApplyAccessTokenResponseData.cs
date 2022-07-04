using System.Text.Json.Serialization;

namespace Millheat.Api.Json
{
    internal class ApplyAccessTokenResponseData
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
    }
}