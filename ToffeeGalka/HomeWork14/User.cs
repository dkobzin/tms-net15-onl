using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HomeWork14
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        [JsonIgnore]
        public int? IDCard;
        public User()
        {
        }
        public User(string firstName, string lastName, int age, int iDCard)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IDCard = iDCard;
        }
    }
}
