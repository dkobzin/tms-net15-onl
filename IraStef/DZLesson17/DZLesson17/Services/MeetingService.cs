using DZLesson17.Models;

namespace DZLesson17.Services
{
    public class MeetingService : IMeetingService
    {
        private Meeting[] meetingStorage;
        public MeetingService()
        {
            meetingStorage = new Meeting[]
            {
                new Meeting(){Name = "Meeting1", PeopleCount = 55, MeetingMaxTime = new TimeSpan (5,30,0) },
                new Meeting(){Name = "Meeting2", PeopleCount = 15, MeetingMaxTime = new TimeSpan (3,0,0) },
                new Meeting(){Name = "Meeting3", PeopleCount = 5, MeetingMaxTime = new TimeSpan (1,30,0) }

            };
        }
        public Meeting[] GetMeetings()
        {
            return meetingStorage;
        }
        public void UpdateMeetings(Meeting[] meetings) 
        {
            meetingStorage = meetings;
        }
        
    }
}
