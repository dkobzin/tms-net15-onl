using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class UserMeetingEntity
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdMeeting { get; set; }
        public MeetingEntity Meeting { get; set; }
        public UserEntity User { get; set; }
    }
}
