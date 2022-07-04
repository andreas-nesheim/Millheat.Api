using System.Text.Json.Serialization;

namespace Millheat.Api.Json
{
    internal class SelectRoombyHomeResponseData
    {
        [JsonPropertyName("roomList")]
        public Room[] Rooms { get; set; }
    }
}
