using Microsoft.AspNetCore.Mvc;
using DAL;
using DAL.Entities;
using MeetingRoomWebApi.Models;
using MeetingRoomWebApi.Services;

namespace MeetingRoomWebApi.Controllers;

[Route("[controller]"), ApiController]
public class MeetingController(ApplicationDbContext dbContext, IMeetingService meetingService) : ControllerBase
{
    [HttpPost("AddMeeting")]
    public void AddMeeting([FromBody] Meeting meeting) =>
        meetingService.AddMeeting(meeting);

    [HttpPut("EditMeeting")]
    public void EditMeeting(Meeting meeting) =>
        meetingService.EditMeeting(meeting);

    [HttpDelete("DeleteMeeting")]
    public void DeleteMeeting(int meetingId) =>
        meetingService.DeleteMeeting(meetingId);
    
    [HttpGet("GetMeeting")]
    public List<MeetingEntity> Get() => dbContext.Meetings.ToList();
}