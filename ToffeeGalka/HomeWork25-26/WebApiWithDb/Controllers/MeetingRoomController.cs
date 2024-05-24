using DataAccessLayer.Entities;
using DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiWithDb.Services;

namespace WebApiWithDb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MeetingRoomController(ApplicationDbContext dbContext, IMeetingRoomService meetingRoomService) : ControllerBase
    {

        [HttpGet("GetMeetingRoom")]
        public MeetingRoomEntity[] Get()
        {
            var meetingroom = dbContext.MeetingRooms.ToArray();
            return meetingroom;
        }
        [HttpPost("AddMeetingRoom")]
        public async Task AddMeetingRoom(MeetingRoomEntity name)=>await meetingRoomService.AddMeetingRoom(name);
        [HttpPost("EditMeetingRoom")]
        public async Task EditMeetingRoom(MeetingRoomEntity meetingRoom) => await meetingRoomService.EditMeetingRoom(meetingRoom);
        [HttpPost("DeleteMeetingRoom")]
        public async Task DeleteMeetingRoom(int idMeetingRoom) => await meetingRoomService.DeleteMeetingRoom(idMeetingRoom);
    }
}
