namespace AleksandrHw16.Models
{
    public class MeetingRoom
    {
        public DateTime Time { get; set; }
        public int QuantityPeople { get; set; }
        public TimeSpan MaxMeetingDuration { get; set; }
        public MeetingRoom(DateTime time, int quantityPeople, TimeSpan maxMeetingDuration)
        {
            Time = time;
            QuantityPeople = quantityPeople;
            MaxMeetingDuration = maxMeetingDuration;
        }

    }
}
