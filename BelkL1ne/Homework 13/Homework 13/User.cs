using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_13
{
    internal class User 
    {
        private string login;
        private string password;
        private string confirmPassword;
        public User(string login, string password)
        { Login = login; Password = password; ConfirmPassword = "Cartoon13"; }
        public string Login {
            get => login;
            set
            {
                if (value == null || value.Length > 20)
                { throw new WrongLoginException("Login length must be less then 20 symbols."); }
                else if (value.IndexOf(" ") != -1)
                { throw new WrongLoginException("The login must not contain spaces"); }
                else { login = value; }
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value == null || value.Length > 20)
                { throw new WrongPasswordException("Password length must be less then 20 symbols."); }
                else if (value.IndexOf(" ") != -1)
                { throw new WrongPasswordException("The password must not contain spaces"); }
                else if (!IsContainsDigit(value))
                { throw new WrongPasswordException("The password must contain digits"); }
                else { password = value; }
            }
        }
        public string ConfirmPassword 
        { 
            get => confirmPassword; 
            set => confirmPassword = value;
        } 


        private bool IsContainsDigit(string value)
        {
            foreach (char c in value)
            {
                if (char.IsDigit(c)) return true;
            }
            return false;
        }
    }
}
