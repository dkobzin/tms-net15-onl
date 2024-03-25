using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    internal class User
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string ConfirmPassword { get; private set; }
        public User(string login, string password, string confirmPassword)
        {
            Login = login;
            Password = password;
            ConfirmPassword = confirmPassword;
        }
        public bool CheckLogin()
        {
            if (string.IsNullOrEmpty(Login))
            {
                throw new WrongLoginException("Invalid login! Login field is null or empty");
            }
            if (Login.Length >= 20)
            {
                throw new WrongLoginException("Invalid login! Login field is null or empty");
            }
            return true;
        }
        public bool CheckPassword()
        {
            if (string.IsNullOrEmpty(Password))
            {
                throw new WrongPasswordException("Invalid Password! Password field is null or empty");
            }
            if (Password.Length < 20)
            {
                throw new WrongPasswordException("Invalid Password! It is shorter than 20");
            }
            if (Password.Any(c => c == ' '))
            {
                throw new WrongPasswordException("Invalid Password! It contains spase(s)");
            }
            if (!Password.Any(c => char.IsDigit(c)))
            {
                throw new WrongPasswordException("Invalid Password! It does not conttain any digit");
            }
            if (Password != ConfirmPassword)
            {
                throw new WrongPasswordException("Password and Confirm Password are not equal");
            }
            return true;
        }

    }
}
