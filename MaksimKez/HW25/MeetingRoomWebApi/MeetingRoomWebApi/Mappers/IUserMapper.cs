using DAL.Entities;
using MeetingRoomWebApi.Models;

namespace MeetingRoomWebApi;

public interface IUserMapper
{
    public UserEntity MapToEntity(User user);
}