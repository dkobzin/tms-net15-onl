using System.Text.Json.Serialization;

namespace DZLesson14
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        [JsonIgnore]


        public string IdCard { get; set; }

        public User(string firstName, string lastName, int age, string idCard)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IdCard = idCard;
        }

        public User(){ }
    }
}
