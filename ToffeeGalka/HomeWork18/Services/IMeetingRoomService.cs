using HomeWork18.Models;

namespace HomeWork18.Services
{
    public interface IMeetingRoomService
    {
        public MeetingRoom GetMeeting();
        public bool EditRoom(MeetingRoomEdit roomData);
    }
}
