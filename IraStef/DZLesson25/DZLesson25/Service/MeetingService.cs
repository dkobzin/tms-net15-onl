using DZLesson25.DB;
using Microsoft.EntityFrameworkCore;

namespace DZLesson25.Service
{
    public class MeetingService(MeetingDbContext context) : IMeetingService
    {
        public async Task CreateMeetingRoom(MeetingRoom room)
        {
            context.MeetingRooms.Add(room);
            await context.SaveChangesAsync();
        }
        public async Task CreateMeeting(MeetingRoom room, string name)
        {
            context.Meetings.Add(new Meeting { IdRoom = room.Id, Name = name });
            await context.SaveChangesAsync();
        }
        public async Task CreateUser(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
        }
        public async Task AddUserToMeeting(int userId, int meetingId)
        {
            context.UsersInMetings.Add(new UsersInMeeting
            {
                IdMeeting = meetingId,
                IdUser = userId,
            });
            await context.SaveChangesAsync();
        }

        public async Task EditMeeting(Meeting meeting)
        {
            var oldValue = await context.Meetings.FirstOrDefaultAsync(t => t.Id == meeting.Id);
            if (oldValue == null)
                return;

            oldValue.Name = meeting.Name;
            oldValue.IdRoom = meeting.IdRoom;

            await context.SaveChangesAsync();
        }
        public async Task EditUser(User user)
        {
            var oldValue = await context.Users.FirstOrDefaultAsync(t => t.Id == user.Id);
            if (oldValue == null)
                return;

            oldValue.Name = user.Name;

            await context.SaveChangesAsync();
        }

        public async Task RemoveMeeting(int meetingId)
        {
            var meeting = await context.Meetings.FirstOrDefaultAsync(t => t.Id == meetingId);
            if (meeting == null)
                return;

            context.Meetings.Remove(meeting);
            await context.SaveChangesAsync();
        }
        public async Task RemoveUserFromMeeting(int meetingId, int userId)
        {
            var userInMeeting = await context.UsersInMetings.FirstOrDefaultAsync(t => t.IdUser == userId && t.IdMeeting == meetingId);
            if (userInMeeting == null)
                return;

            context.Remove(userInMeeting);
            await context.SaveChangesAsync();
        }

        public async Task<List<MeetingRoom>> GetMeetingRooms()
        {
            return await context.MeetingRooms.ToListAsync();
        }

        public async Task<List<Meeting>> GetMeetings()
        {
            return await context.Meetings.ToListAsync();
        }

        public async Task<List<User>> GetUsers()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<List<User>> GetUsersInMeeting(int meetingId)
        {
            return await context.UsersInMetings.Include(t => t.User).Where(x => x.IdMeeting == meetingId).Select(t => t.User!).ToListAsync();
        }

    }
}
