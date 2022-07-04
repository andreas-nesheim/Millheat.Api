using System.Text.Json.Serialization;

namespace Millheat.Api.Json
{
    internal class SelectRoombyHomeResponse : BaseResponse
    {
        [JsonPropertyName("data")]
        public SelectRoombyHomeResponseData Data { get; set; }
    }
}
