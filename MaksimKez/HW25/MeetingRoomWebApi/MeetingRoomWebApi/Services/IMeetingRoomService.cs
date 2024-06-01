using MeetingRoomWebApi.Models;

namespace MeetingRoomWebApi.Services;

public interface IMeetingRoomService
{
    public void AddMeetingRoom(MeetingRoom room);
    public void DeleteMeetingRoom(int idMeetingRoom);
    public void EditMeetingRoom(MeetingRoom meetingRoom);
}