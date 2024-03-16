using System.ComponentModel.DataAnnotations;

namespace HomeWork10.Authorase
{
    public class User
    {
        [MaxLength(20)]
        public string Login {  get; private set; }
        [MaxLength(20)]
        public string Password { get; private set; }
        public string ConfirmPassword { get; private set; }
        public User(string login, string password, string confirmPassword)
        {
            Login = login;
            Password = password;
            ConfirmPassword = confirmPassword;
             
        }
    }
}
