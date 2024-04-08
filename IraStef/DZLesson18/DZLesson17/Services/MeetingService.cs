using DZLesson18.Models;
using System.Text.Json;

namespace DZLesson18.Services
{
    public class MeetingService : IMeetingService
    {
        private IConfiguration configuration;
        public MeetingService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public MeetingView GetMeetings()
        {
            return new MeetingView() 
            { 
                Meetings = configuration.GetSection("Meetings").Get<Meeting[]>() 
            };
        }
        public void UpdateMeetings(MeetingUpdate meetings) 
        {
            var meetingData = meetings.Meetings;
            configuration["Meetings"] = JsonSerializer.Serialize(meetingData);
        }   
    }
}
