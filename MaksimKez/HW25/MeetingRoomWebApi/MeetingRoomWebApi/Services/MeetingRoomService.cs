using DAL;
using MeetingRoomWebApi.Models;

namespace MeetingRoomWebApi.Services;

public class MeetingRoomService(ApplicationDbContext context, IMeetingRoomMapper mapper) : IMeetingRoomService
{
    public void AddMeetingRoom(MeetingRoom room)
    {
        context.Rooms.Add(mapper.MapToEntity(room));
        context.SaveChanges();
    }

    public void DeleteMeetingRoom(int idMeetingRoom)
    {
        var meetingRoomEntity = context.Rooms.FirstOrDefault(p => p.Id == idMeetingRoom);
        if (meetingRoomEntity is null)
            return;
        context.Remove(meetingRoomEntity);
        context.SaveChanges();
    }

    public void EditMeetingRoom(MeetingRoom meetingRoom)
    {
        var oldMeetingRoomEntity = context.Rooms.FirstOrDefault(p => p.Id == meetingRoom.Id);
        if (oldMeetingRoomEntity is null)
            return;
        oldMeetingRoomEntity.Name = meetingRoom.Name;
        oldMeetingRoomEntity.Capacity = meetingRoom.Capacity;
        context.SaveChanges();
    }
}