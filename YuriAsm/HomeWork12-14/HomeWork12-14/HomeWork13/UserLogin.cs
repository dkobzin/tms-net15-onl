namespace HomeWork12_14.HomeWork13
{
    public class UserLogin
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string ConfirmPassword { get; private set; }
        public UserLogin(string login, string password , string confirmPassword)
        {
            Login = login;
            Password = password;
            ConfirmPassword = confirmPassword;
        }
    }
}
