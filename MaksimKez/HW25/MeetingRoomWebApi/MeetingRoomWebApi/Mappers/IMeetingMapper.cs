using DAL.Entities;
using MeetingRoomWebApi.Models;
using MeetingRoomWebApi.Services;

namespace MeetingRoomWebApi;

public interface IMeetingMapper
{ 
    Meeting MapToModel(MeetingEntity entity);
    MeetingEntity MapToEntity(Meeting model);
}