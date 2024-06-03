using DZLesson25.DB;
using DZLesson25.Service;
using Microsoft.AspNetCore.Mvc;

namespace DZLesson25.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class MeetingController(IMeetingService meetingService) : ControllerBase
    {
        [HttpGet("GetMeetingRooms")]
        public async Task<List<MeetingRoom>> GetMeetingRooms() => await meetingService.GetMeetingRooms();
        [HttpGet("GetMeetings")]
        public async Task<List<Meeting>> GetMeetings() => await meetingService.GetMeetings();
        [HttpGet("GetUsers")]
        public async Task<List<User>> GetUsers() => await meetingService.GetUsers();
        [HttpGet("GetUsersInMeeting")]
        public async Task<List<User>> GetUsersInMeeting(int meetingId) => await meetingService.GetUsersInMeeting(meetingId);

        [HttpPost("CreateMeetingRoom")]
        public async Task CreateMeetingRoom(MeetingRoom room) => await meetingService.CreateMeetingRoom(room);
        [HttpPost("CreateMeeting")]
        public async Task CreateMeeting(MeetingRoom room, string name) => await meetingService.CreateMeeting(room, name);
        [HttpPost("CreateUser")]
        public async Task CreateUser(User user) => await meetingService.CreateUser(user);
        [HttpPost("AddUserToMeeting")]
        public async Task AddUserToMeeting(int userId, int meetingId) => await meetingService.AddUserToMeeting(userId, meetingId);
        [HttpPost("EditMeeting")]
        public async Task EditMeeting(Meeting meeting) => await meetingService.EditMeeting(meeting);
        [HttpPost("EditUser")]
        public async Task EditUser(User user) => await meetingService.EditUser(user);
        [HttpPost("RemoveMeeting")]
        public async Task RemoveMeeting(int meetingId) => await meetingService.RemoveMeeting(meetingId);
        [HttpPost("RemoveUserFromMeeting")]
        public async Task RemoveUserFromMeeting(int meetingId, int userId) => await meetingService.RemoveUserFromMeeting(meetingId, userId);
    }
}
