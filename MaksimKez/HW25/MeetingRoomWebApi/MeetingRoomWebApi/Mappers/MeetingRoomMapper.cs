using DAL.Entities;
using MeetingRoomWebApi.Models;

namespace MeetingRoomWebApi;

public class MeetingRoomMapper :IMeetingRoomMapper
{
    public MeetingRoom MapToModel(MeetingRoomEntity entity)
    {
        return new MeetingRoom
        {
            Id = entity.Id,
            Name = entity.Name,
            Capacity = entity.Capacity
        };
    }

    public MeetingRoomEntity MapToEntity(MeetingRoom model)
    {
        return new MeetingRoomEntity
        {
            Id = model.Id,
            Name = model.Name,
            Capacity = model.Capacity
        };
    }
}