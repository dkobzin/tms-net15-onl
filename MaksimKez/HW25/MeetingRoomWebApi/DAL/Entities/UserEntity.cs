using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Users")]
    public class UserEntity
    {
        [Required, Column("Id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Username { get; set; }

        [Required, Column("Email")]
        public string Email { get; set; }
    }
}
