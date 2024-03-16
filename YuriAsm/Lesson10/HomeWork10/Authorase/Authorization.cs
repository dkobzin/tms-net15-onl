using HomeWork10.Authorase.ValidateUser;

namespace HomeWork10.Authorase
{
    public class Authorization
    {
         public static bool Login(User user)
        {
            if(user == null)
                return false;

            if (user.Login.Length >= 20 || user.Login.Length != user.Login.Replace(" ","").Length)
                 throw new WrongLoginExeption("Login is too long, max 20 char");

            if (user.Password == null)
                throw new WrongPasswordExeption("Password");

            if (user.Password.Length >= 20 || user.Password.Length != user.Password.Replace(" ", "").Length || user.Password.Any(char.IsDigit))
                throw new WrongPasswordExeption("Password is not valedate.");

            if(user.Password != user.ConfirmPassword)
                throw new WrongPasswordExeption("Please, get password again");

            return true;

        }
    }
}
