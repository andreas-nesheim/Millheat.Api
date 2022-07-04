using System.Text.Json.Serialization;

namespace Millheat.Api.Json
{
    internal class SelectDevicebyRoomResponseData
    {
        [JsonPropertyName("deviceList")]
        public Device[] Devices { get; set; }
    }
}
