using MeetingRoomWebApi.Models;

namespace MeetingRoomWebApi.Services;
public interface IMeetingService
{
    void AddMeeting(Meeting meeting);
    void DeleteMeeting(int idMeeting);
    void EditMeeting(Meeting meeting);
}