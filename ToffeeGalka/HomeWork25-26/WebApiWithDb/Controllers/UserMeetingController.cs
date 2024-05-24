using DataAccessLayer.Entities;
using DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiWithDb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserMeetingController(ApplicationDbContext dbContext) : ControllerBase
    {

        [HttpGet("GetUserMeeting")]
        public UserMeetingEntity[] Get()
        {
            var usermeeting = dbContext.UserMeetings.ToArray();
            return usermeeting;
        }
    }
}
