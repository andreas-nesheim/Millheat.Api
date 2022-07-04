using System.Text.Json.Serialization;

namespace Millheat.Api.Json
{
    public class Room
    {
        [JsonPropertyName("maxTemperature")]
        public int MaxTemperature { get; set; }
        [JsonPropertyName("maxTemperatureMsg")]
        public string MaxTemperatureMsg { get; set; }
        [JsonPropertyName("changeTemperature")]
        public int ChangeTemperature { get; set; }
        [JsonPropertyName("controlSource")]
        public string ControlSource { get; set; }
        [JsonPropertyName("comfortTemp")]
        public int ComfortTemp { get; set; }
        [JsonPropertyName("roomProgram")]
        public string RoomProgram { get; set; }
        [JsonPropertyName("awayTemp")]
        public int AwayTemp { get; set; }
        [JsonPropertyName("avgTemp")]
        public float AvgTemp { get; set; }
        [JsonPropertyName("changeTemperatureMsg")]
        public string ChangeTemperatureMsg { get; set; }
        [JsonPropertyName("roomId")]
        public long RoomId { get; set; }
        [JsonPropertyName("roomName")]
        public string RoomName { get; set; }
        [JsonPropertyName("currentMode")]
        public int CurrentMode { get; set; }
        [JsonPropertyName("heatStatus")]
        public int HeatStatus { get; set; }
        [JsonPropertyName("offLineDeviceNum")]
        public int OffLineDeviceNum { get; set; }
        [JsonPropertyName("total")]
        public int Total { get; set; }
        [JsonPropertyName("independentCount")]
        public int IndependentCount { get; set; }
        [JsonPropertyName("sleepTemp")]
        public int SleepTemp { get; set; }
        [JsonPropertyName("onlineDeviceNum")]
        public int OnlineDeviceNum { get; set; }
        [JsonPropertyName("isOffline")]
        public int IsOffline { get; set; }
    }
}
