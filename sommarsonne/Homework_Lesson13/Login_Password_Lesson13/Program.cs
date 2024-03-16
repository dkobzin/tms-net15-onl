using System.Security.Cryptography.X509Certificates;

namespace Login_Password_Lesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.GetLoginPassword();

            Console.WriteLine($"Login: {user.login}");
            Console.WriteLine($"Password: {user.password}");

            Console.ReadLine();
        }
    }
   
}