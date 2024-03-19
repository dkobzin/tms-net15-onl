using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW14
{
    [Serializable]
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        [JsonIgnore]
        public string IDCard { get; set; }
        public User(string name, string surname, int age, string iDCard)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IDCard = iDCard;
        }
    }
}
