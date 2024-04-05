using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace hw16.Models
{
    [Serializable]
    public class MeetingSettings
    {
        [JsonProperty("MaxPeople")]
        [Display(Name = "Maximum People")]
        public int MaxPeople { get; set; }

        [JsonProperty("MaxTime")]
        [Display(Name = "Maximum Time")]
        public TimeSpan MaxTime { get; set; }
    }
}
