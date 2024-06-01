using DAL;
using DAL.Entities;
using MeetingRoomWebApi.Models;
using MeetingRoomWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetingRoomWebApi.Controllers;

[Route("[controller]"), ApiController]

public class UsersController(ApplicationDbContext dbContext, IUserService userService) : ControllerBase
{

    [HttpGet("GetUsers")]
    public UserEntity[] Get() => dbContext.Users.ToArray();

    [HttpDelete("DeleteUser")]
    public void DeleteUser(int id) =>
        userService.DeleteUser(id);

    [HttpPut("EditUser")]
    public void EditUser(User user) =>
        userService.EditUser(user);

    [HttpPost("AddUser")]
    public void AddUser([FromBody]User user) =>
        userService.AddUser(user);
}