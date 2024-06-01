using DAL.Entities;
using MeetingRoomWebApi.Models;

namespace MeetingRoomWebApi;

public interface IMeetingRoomMapper
{
    MeetingRoom MapToModel(MeetingRoomEntity entity);
    MeetingRoomEntity MapToEntity(MeetingRoom model);
}