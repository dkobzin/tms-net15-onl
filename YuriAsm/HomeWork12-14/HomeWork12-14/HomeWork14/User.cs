using Newtonsoft.Json;
using System.Xml.Serialization;

namespace HomeWork12_14.HomeWork14
{
    public class User
    {
        [JsonProperty("firstname")]
        public string FirstName { get;  set; } = string.Empty;
        [JsonProperty("lastName")]
        public string LastName { get;  set; } = string.Empty;
        [JsonProperty("age")]
        public int Age { get;  set; }
        [JsonIgnore]
        [XmlIgnore]
        public int IdCard { get;  set; }

        public User() { }
        public User(string firstName, string lastName, int age, int idCard = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IdCard = idCard;
        }
    }
}
