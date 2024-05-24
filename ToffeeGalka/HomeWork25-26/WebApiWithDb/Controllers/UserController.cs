using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer;
using DataAccessLayer.Entities;
using WebApiWithDb.Models;
using WebApiWithDb.Services;

namespace WebApiWithDb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController(ApplicationDbContext dbContext, IUserService userService) : ControllerBase
    {

        [HttpGet("GetUsers")]
        public UserEntity[] Get()
        {
            var users = dbContext.Users.ToArray();
            return users;          
        }
        [HttpPost("AddMeetingRoom")]
        public async Task AddUser(string surName, string name, string secName, string email) => await userService.AddUser(surName, name, secName, email);
        [HttpGet("QueryUserMiting")]

        public async Task<UserEntity> QueryUser()
        {
           var query = await userService.QueryUser();
            return query;
        }
    }
}
