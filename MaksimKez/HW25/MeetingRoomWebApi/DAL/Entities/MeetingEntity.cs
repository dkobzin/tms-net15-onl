using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Meetings")]
    public class MeetingEntity
    {
        [Required, Column("Id")]
        public int Id { get; set; }

        [Required, Column("Title")]
        public string Title { get; set; }

        [Column("StartTime")]
        public DateTime StartTime { get; set; }

        [Column("EndTime")]
        public DateTime EndTime { get; set; }

        [Required, Column("MeetingRoomId")]
        public int MeetingRoomId { get; set; }

        [Column("Room")]
        public MeetingRoomEntity MeetingRoom { get; set; }

        [Column("ParticipantIds")]
        public ICollection<UserEntity> Participants { get; set; }
    }
}
