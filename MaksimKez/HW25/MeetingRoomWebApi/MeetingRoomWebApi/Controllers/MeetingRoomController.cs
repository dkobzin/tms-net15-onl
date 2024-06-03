using DAL;
using DAL.Entities;
using MeetingRoomWebApi.Models;
using MeetingRoomWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetingRoomWebApi.Controllers;

[Route("[controller]"), ApiController]
public class MeetingRoomController(ApplicationDbContext dbContext, IMeetingRoomService meetingRoomService) : ControllerBase
{
    [HttpGet("GetMeetingRooms")]
    public List<MeetingRoomEntity> Get() => 
        dbContext.Rooms.ToList();
    
    [HttpPost("AddMeetingRoom")]
    public void AddMeetingRoom(MeetingRoom name)
        => meetingRoomService.AddMeetingRoom(name);
    
    [HttpPut("EditMeetingRoom")]
    public void EditMeetingRoom(MeetingRoom meetingRoom)
        => meetingRoomService.EditMeetingRoom(meetingRoom);
    
    [HttpDelete("DeleteMeetingRoom")]
    public void DeleteMeetingRoom(int idMeetingRoom)
        => meetingRoomService.DeleteMeetingRoom(idMeetingRoom);
}