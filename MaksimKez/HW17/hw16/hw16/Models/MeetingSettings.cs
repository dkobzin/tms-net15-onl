using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace hw16.Models
{
    [Serializable]
    public class MeetingSettings
    {
        public int MaxPeople { get; set; }

        public TimeSpan MaxTime { get; set; }
    }
}
