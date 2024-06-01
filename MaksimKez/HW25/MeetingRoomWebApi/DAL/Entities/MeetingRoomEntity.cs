using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DAL.Entities
{
    [Table("MeetingRooms")]
    public class MeetingRoomEntity
    {
        [Required, Column("Id")]
        public int Id { get; set; }

        [Required, Column("Name")]
        public string Name { get; set; }

        [Column("Capacity")]
        public int Capacity { get; set; }
    }
}
