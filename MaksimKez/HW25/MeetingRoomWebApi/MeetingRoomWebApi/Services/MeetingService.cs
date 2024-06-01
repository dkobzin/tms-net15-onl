using DAL;
using DAL.Entities;
using MeetingRoomWebApi.Models;

namespace MeetingRoomWebApi.Services;

public class MeetingService(ApplicationDbContext context, IMeetingMapper mapper) : IMeetingService
{
    public void AddMeeting(Meeting meeting)
    {
        context.Meetings.Add(mapper.MapToEntity(meeting));
        context.SaveChanges();
    }

    public void DeleteMeeting(int idMeeting)
    {
        var meetingEntity = context.Meetings.FirstOrDefault(p => p.Id == idMeeting);
        if (meetingEntity is null)
            return;
        context.Remove(meetingEntity);
        context.SaveChanges();
    }

    public void EditMeeting(Meeting meeting)
    {
        var oldMeetingEntity = context.Meetings.FirstOrDefault(p => p.Id == meeting.Id);
        if (oldMeetingEntity is null)
            return;
        oldMeetingEntity.Title = meeting.Title;
        oldMeetingEntity.StartTime = meeting.StartTime;
        oldMeetingEntity.EndTime = meeting.EndTime;
        oldMeetingEntity.MeetingRoomId = meeting.MeetingRoomId;
        context.SaveChanges();
    }
}

