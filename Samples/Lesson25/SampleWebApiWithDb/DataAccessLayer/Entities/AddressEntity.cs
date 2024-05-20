using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class AddressEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public virtual UserEntity User { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Appartment { get; set; }
        public string Type { get; set; }
    }
}
