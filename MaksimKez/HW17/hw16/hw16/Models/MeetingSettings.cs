using Newtonsoft.Json;

namespace hw16.Models
{
    public class MeetingSettings
    {
        public int MaxPeople { get; set; }

        public TimeSpan MaxTime { get; set; }
    }
}
