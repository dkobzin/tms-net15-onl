using MeetingRoomWebApi.Models;

namespace MeetingRoomWebApi.Services;

public interface IUserService
{
    void AddUser(User user);
    void DeleteUser(int userId);
    void EditUser(User user);
}