using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZLesson13
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public User(string login, string password, string confirmPassword) 
        {
            Login = login;
            Password = password;
            ConfirmPassword = confirmPassword;
        }
    }
}
