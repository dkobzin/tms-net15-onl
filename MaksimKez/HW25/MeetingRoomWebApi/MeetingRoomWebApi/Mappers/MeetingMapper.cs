using DAL.Entities;
using MeetingRoomWebApi.Models;

namespace MeetingRoomWebApi;

public class MeetingMapper : IMeetingMapper
{
    public Meeting MapToModel(MeetingEntity entity)
    {
        return new Meeting
        {
            EndTime = entity.EndTime,
            Id = entity.Id,
            MeetingRoomId = entity.MeetingRoomId,
            StartTime = entity.StartTime,
            Title = entity.Title
        };
    }

    public MeetingEntity MapToEntity(Meeting model)
    {
        return new MeetingEntity
        {
            EndTime = model.EndTime,
            Id = model.Id,
            MeetingRoomId = model.MeetingRoomId,
            StartTime = model.StartTime,
            Title = model.Title
        };
    }
}