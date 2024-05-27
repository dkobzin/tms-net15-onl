using WebApiHT25and26.Model.IdentityModel;

namespace WebApiHT25and26.Model
{
    public class MeetingRoomModel
    {
        public Person General { get; set; } = null!;
        public IList<Person>? MembersMeetingRoom => new List<Person>();
    }
}
