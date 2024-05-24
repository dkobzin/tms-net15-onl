namespace DZLesson25.DB
{
    public class Meeting
    {
        public int Id { get; set; }
        public int IdRoom { get; set; }
        public required string Name { get; set; }

        public MeetingRoom? Room { get; set; }
        public UsersInMeeting[]? usersInMeetings { get; set; }
    }
}
