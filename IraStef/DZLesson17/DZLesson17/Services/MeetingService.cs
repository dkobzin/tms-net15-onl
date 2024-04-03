using DZLesson17.Models;
using System.Text.Json;

namespace DZLesson17.Services
{
    public class MeetingService : IMeetingService
    {
        private IConfiguration configuration;
        public MeetingService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public Meeting[] GetMeetings()
        {
            var foo = configuration.GetSection("Meetings").Get<Meeting[]>();
            return foo;
        }
        public void UpdateMeetings(Meeting[] meetings) 
        {
            configuration["Meetings"] = JsonSerializer.Serialize(meetings);
        }   
    }
}
