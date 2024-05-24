using DataAccessLayer.Entities;
using WebApiWithDb.Models;

namespace WebApiWithDb.Services
{
    public interface IMeetingRoomService
    {
        public Task AddMeetingRoom(MeetingRoomEntity name);
        public Task EditMeetingRoom(MeetingRoomEntity meetingRoom);
        public Task DeleteMeetingRoom(int idMeetingRoom);
    }
}
