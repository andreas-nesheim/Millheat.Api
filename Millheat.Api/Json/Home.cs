using System.Text.Json.Serialization;

namespace Millheat.Api.Json
{
    public class Home
    {
        [JsonPropertyName("homeName")]
        public string HomeName { get; set; }
        [JsonPropertyName("isHoliday")]
        public int IsHoliday { get; set; }
        [JsonPropertyName("holidayStartTime")]
        public int HolidayStartTime { get; set; }
        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }
        [JsonPropertyName("modeMinute")]
        public int ModeMinute { get; set; }
        [JsonPropertyName("modeStartTime")]
        public int ModeStartTime { get; set; }
        [JsonPropertyName("holidayTemp")]
        public int HolidayTemp { get; set; }
        [JsonPropertyName("modeHour")]
        public int ModeHour { get; set; }
        [JsonPropertyName("currentMode")]
        public int CurrentMode { get; set; }
        [JsonPropertyName("holidayEndTime")]
        public int HolidayEndTime { get; set; }
        [JsonPropertyName("homeType")]
        public object HomeType { get; set; }
        [JsonPropertyName("homeId")]
        public long HomeId { get; set; }
        [JsonPropertyName("programId")]
        public long ProgramId { get; set; }
    }
}
