namespace DZLesson25.DB
{
    public class UsersInMeeting
    { 
        public int IdUser { get; set; }
        public int IdMeeting { get; set; }

        public User? User { get; set; }
        public Meeting? Meeting { get; set; }
    }
}
