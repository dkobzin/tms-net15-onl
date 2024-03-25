using System.Runtime.CompilerServices;

namespace HomeWork13
{
        internal class Program
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Login:");
            string login = Console.ReadLine();

            Console.WriteLine("Input Password:");
            string password = Console.ReadLine();

            Console.WriteLine("Input ConfirmPassword:");
            string confirmPassword = Console.ReadLine();

            User user = new User(login, password, confirmPassword);
            Console.WriteLine(Login(user));
        }
        static bool Login(User user)
            {
                try
                {
                    user.LoginCheck();
                    user.PasswordCheck();
                }
                catch (WrongLoginException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Authentication error!");
                return false;
                }
                catch (WrongPasswordException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Authentication error!");
                return false;
                }
                Console.WriteLine("Authentication completed successfully!");
                return true;
            }
        }
}
