namespace DZLesson16
{
    public class MeetingService: IMeetingService
    {
        public Meeting GetMeeting()
        {
            return new Meeting() { PeopleCount = 5, MeetingMaxTime = new TimeSpan(1, 30, 0) };
        }
    }
}
