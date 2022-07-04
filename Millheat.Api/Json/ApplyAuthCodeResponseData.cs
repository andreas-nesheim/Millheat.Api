using System.Text.Json.Serialization;

namespace Millheat.Api.Json
{
    internal class ApplyAuthCodeResponseData
    {
        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }
    }
}
