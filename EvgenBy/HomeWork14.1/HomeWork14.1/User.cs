using System;
using System.Text;
using System.Text.Json.Serialization;



namespace HomeWork14
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        [JsonIgnore] public int IDCard { get; set; }

        public User()
        {
        }

        public User(string firstName, string lastName, int age, int idCard)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IDCard = idCard;
        }

    }
}
