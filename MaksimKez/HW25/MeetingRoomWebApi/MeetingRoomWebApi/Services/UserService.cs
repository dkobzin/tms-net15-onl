using DAL;
using DAL.Entities;
using MeetingRoomWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetingRoomWebApi.Services;

public class UserService(ApplicationDbContext context, IUserMapper mapper) : IUserService
{
    public void AddUser(User user)
    {
        var userEntity = mapper.MapToEntity(user);
        context.Add(userEntity);
        context.SaveChanges();
    }

    public void DeleteUser(int userId)
    {
        var userEntity = context.Users.FirstOrDefault(p => p.Id == userId);
        if (userEntity is null)
            return;
        context.Remove(userEntity);
        context.SaveChanges();
    }

    public void EditUser(User user)
    {
        var oldUser = context.Users.FirstOrDefault(p => p.Id == user.Id);
        if (oldUser is null)
            return;
        oldUser.Username = user.Username;
        oldUser.Email = user.Email;
        context.SaveChanges();
    }
}

    
