
namespace DataAccessLayer.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string SecName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<UserMeetingEntity> Meetings { get; set; }

    }
}
