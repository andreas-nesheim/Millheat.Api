using System.Text.Json.Serialization;

namespace Millheat.Api.Json
{
    internal class BaseResponse
    {
        [JsonPropertyName("errorCode")]
        public int ErrorCode { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
