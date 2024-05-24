namespace DZLesson25.DB
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public UsersInMeeting[]? usersInMeetings { get; set; }
    }
}
