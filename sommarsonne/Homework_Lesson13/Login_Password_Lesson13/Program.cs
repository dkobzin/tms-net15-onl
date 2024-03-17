using System.Security.Cryptography.X509Certificates;

namespace Login_Password_Lesson13
{
    internal class Program
    {
        public static bool Login(User user)
        {
            if (string.IsNullOrWhiteSpace(user.login) || user.login.Length >= 20 || user.login.Contains(" "))
            {
                throw new WrongLoginException("Login can't be longer than 20 characters.");
            }

            if (string.IsNullOrWhiteSpace(user.password) || user.password.Length >= 20 || user.password.Contains(" ") || !HasDigit(user.password))
            {
                throw new WrongPasswordException("Password can't be longer than 20 characters and must have a number.");
            }

            if (user.password != user.confirmPassword)
            {
                throw new WrongPasswordException("Passwords don't match.");
            }

            return true;
        }

        private static bool HasDigit(string sample)
        {
            foreach (char character in sample)
            {
                if (char.IsDigit(character))
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            User user = new User();

            Console.Write("Enter your login: ");
            user.login = Console.ReadLine();

            Console.Write("Enter your password: ");
            user.password = Console.ReadLine();

            Console.Write("Confirm your password: ");
            user.confirmPassword = Console.ReadLine();

            try
            {
                bool result = Login(user);
                Console.WriteLine($"Login successful: {result}");
            }
            catch (WrongLoginException ex)
            {
                Console.WriteLine($"Login error: {ex.Message}");
            }
            catch (WrongPasswordException ex)
            {
                Console.WriteLine($"Password error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
   
}