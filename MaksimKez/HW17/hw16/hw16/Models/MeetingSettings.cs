using Newtonsoft.Json;

namespace hw16.Models
{
    [Serializable]
    public class MeetingSettings
    {
        [JsonProperty("MaxPeople")]
        public int MaxPeople { get; set; }

        [JsonProperty("MaxTime")]
        public TimeSpan MaxTime { get; set; }
    }
}
