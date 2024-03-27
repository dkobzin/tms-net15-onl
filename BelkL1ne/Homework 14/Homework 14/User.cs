using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Homework_14
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        [JsonIgnore]
        public string IDCard { get; set; }
        public User(string firstName, string lastName, string age, string idCard)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IDCard = idCard;
        }
        public User() { }

    }
}
