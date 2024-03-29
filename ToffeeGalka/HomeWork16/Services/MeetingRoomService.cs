using HomeWork16.Models;

namespace HomeWork16.Services
{
    public class MeetingRoomService : IMeetingRoomService
    {
        private readonly IConfiguration _configuration;
        public MeetingRoomService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public MeetingRoom GetMeeting() 
        {
            var peoples = _configuration.GetValue<int>("MaxPeople");
            var durationMinutes = _configuration.GetValue<int>("MaxTime");
        return new MeetingRoom() { MaxPeople = peoples, MaxTime = TimeSpan.FromMinutes(durationMinutes) };
        }
    }
}
