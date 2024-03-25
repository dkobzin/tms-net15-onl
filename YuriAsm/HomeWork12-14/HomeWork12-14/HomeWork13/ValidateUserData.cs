namespace HomeWork12_14.HomeWork13
{
    public class ValidateUserData
    {
        private static readonly char[] array =
       [
            '0','1','2','3','4','5','6','7','8','9'
       ];
        public static bool ValidateData(UserLogin user)
        {
            if (user.Login == null || user.Login.Length >= 20 || user.Login.Length != user.Login.Replace(" ", " ").Length)
                throw new WrongLoginExeption("Login is not validate");

            if (user.Password == null || user.Password.Length >= 20 || user.Password.Length != user.Password.Replace(" ", " ").Length)
                throw new WrongPasswordExeption("Passowrd is not validate");

            if (user.ConfirmPassword != user.Password)
                throw new WrongPasswordExeption("Password is not validate");
            foreach (char item in user.Password)
            {
                if (array.Contains(item))
                    return true;
                
            }
            throw new WrongPasswordExeption("Passowrd is not validate, add number");
        }
    }
}
