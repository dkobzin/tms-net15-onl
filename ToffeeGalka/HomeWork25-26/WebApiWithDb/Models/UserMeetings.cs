namespace WebApiWithDb.Models
{
    public class UserMeetings
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdMeeting { get; set; }
    }
}
