using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
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
        public bool LoginCheck()
        {
            if (string.IsNullOrEmpty(Login) | Login.Length > 20 | Login.Any(s => s == ' '))
            {
                throw new WrongLoginException("Login error! The login must not be emptyand contain spaces, be less than 20 characters");
            }
                return true;
        }
        public bool PasswordCheck()
        {
            if (string.IsNullOrEmpty(Password) | Password.Length > 20 | Password.Any(s => s == ' ') | !Password.Any(n => char.IsDigit(n)))
            {
                throw new WrongPasswordException("Password error! The password must not be empty or contain spaces. Must have numbers and be less than 20 characters");
            }
            if (Password != ConfirmPassword)
            {
                throw new WrongPasswordException("Password and ConfirmPassword do not match!");
            }
            return true;
        }

    }
}
