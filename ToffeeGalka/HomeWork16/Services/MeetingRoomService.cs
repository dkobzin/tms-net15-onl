using HomeWork16.Models;

namespace HomeWork16.Services
{
    public class MeetingRoomService : IMeetingRoomService
    {
        public MeetingRoom GetMeeting() 
        {
        return new MeetingRoom() { MaxPeople = 10, MaxTime = new TimeSpan (2, 45, 0) };
        }
    }
}
