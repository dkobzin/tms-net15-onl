using DataAccessLayer;
using DataAccessLayer.Entities;
using WebApiWithDb.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiWithDb.Services
{
    public class MeetingRoomService(ApplicationDbContext context) : IMeetingRoomService
    {
        public async Task AddMeetingRoom(MeetingRoomEntity name)
        { 
        context.MeetingRooms.Add(name);
            await context.SaveChangesAsync();
        }
        public async Task EditMeetingRoom(MeetingRoomEntity meetingRoom)
        {
            var oldMeetingRoom = await context.MeetingRooms.FirstOrDefaultAsync(p=>p.Id == meetingRoom.Id);
            if (oldMeetingRoom == null) 
               return;
            oldMeetingRoom.Name=meetingRoom.Name;
            await context.SaveChangesAsync();
        }
        public async Task DeleteMeetingRoom(int idMeetingRoom)
        {
            var meetingRoomId = await context.MeetingRooms.FirstOrDefaultAsync(p=>p.Id == idMeetingRoom);
            if (meetingRoomId == null) 
                return;
            context.Remove(meetingRoomId);
            await context.SaveChangesAsync();
        }
    }

}
