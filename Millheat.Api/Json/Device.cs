using System.Text.Json.Serialization;

namespace Millheat.Api.Json
{
    public class Device
    {
        [JsonPropertyName("maxTemperature")]
        public int MaxTemperature { get; set; }
        [JsonPropertyName("maxTemperatureMsg")]
        public string MaxTemperatureMsg { get; set; }
        [JsonPropertyName("changeTemperature")]
        public int ChangeTemperature { get; set; }
        [JsonPropertyName("canChangeTemp")]
        public int CanChangeTemp { get; set; }
        [JsonPropertyName("deviceId")]
        public int DeviceId { get; set; }
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
        [JsonPropertyName("changeTemperatureMsg")]
        public string ChangeTemperatureMsg { get; set; }
        [JsonPropertyName("mac")]
        public string Mac { get; set; }
        [JsonPropertyName("deviceStatus")]
        public int DeviceStatus { get; set; }
        [JsonPropertyName("heaterFlag")]
        public int HeaterFlag { get; set; }
        [JsonPropertyName("subDomainId")]
        public int SubDomainId { get; set; }
        [JsonPropertyName("controlType")]
        public int ControlType { get; set; }
        [JsonPropertyName("currentTemp")]
        public float CurrentTemp { get; set; }
    }
}
