using DZLesson25.DB;

namespace DZLesson25.Service
{
    public interface IMeetingService
    {
        public Task<List<MeetingRoom>> GetMeetingRooms();
        public Task<List<Meeting>> GetMeetings();
        public Task<List<User>> GetUsers();
        public Task<List<User>> GetUsersInMeeting(int meetingId);

        public Task CreateMeetingRoom(MeetingRoom room);
        public Task CreateMeeting(MeetingRoom room, string name);
        public Task CreateUser(User user);
        public Task AddUserToMeeting(int userId, int meetingId);
        public Task EditMeeting(Meeting meeting);
        public Task EditUser(User user);
        public Task RemoveMeeting(int meetingId);
        public Task RemoveUserFromMeeting(int meetingId, int userId);
    }
}
