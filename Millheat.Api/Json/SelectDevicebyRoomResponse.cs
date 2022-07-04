using System.Text.Json.Serialization;

namespace Millheat.Api.Json
{
    internal class SelectDevicebyRoomResponse : BaseResponse
    {
        [JsonPropertyName("data")]
        public SelectDevicebyRoomResponseData Data { get; set; }
    }
}
