using HomeWork17.Models;

namespace HomeWork17.Services
{
    public interface IMeetingRoomService
    {
        public MeetingRoom GetMeeting();
        public bool EditRoom(MeetingRoomEdit roomData);
    }
}
