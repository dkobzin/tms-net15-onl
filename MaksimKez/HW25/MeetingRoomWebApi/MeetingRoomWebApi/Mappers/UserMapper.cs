using DAL.Entities;
using MeetingRoomWebApi.Models;

namespace MeetingRoomWebApi;

public class UserMapper : IUserMapper
{
    public UserEntity MapToEntity(User user)
    {
        return new UserEntity
        {
            Username = user.Username,
            Email = user.Email
        };
    }
}
