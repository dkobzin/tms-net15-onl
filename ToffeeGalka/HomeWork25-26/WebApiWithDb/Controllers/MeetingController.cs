using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer;

namespace WebApiWithDb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MeetingController(ApplicationDbContext dbContext) : ControllerBase
    {

        [HttpGet("GetMeeting")]
        public MeetingEntity[] Get()
        {
            var meeting = dbContext.Meetings.ToArray();
            return meeting;
        }
    }
}
