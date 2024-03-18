namespace DZLesson13
{
    internal class Program
    {
        public static bool Login(User user)
        {
            if (user == null)
            { throw new ArgumentNullException(); }
            if (user.Login.Length >= 20 || user.Login.Length != user.Login.Replace(" ", "").Length)
            {
                throw new WrongLoginException("Login is wrong!");
            }
            if (user.Password.Length >= 20 ||
                user.Password.Length != user.Password.Replace(" ", "").Length ||
                !user.Password.Any(char.IsDigit))
            {
                throw new WrongPasswordException("Password is wrong!");
            }
            if (user.Password != user.ConfirmPassword)
            {
                throw new WrongPasswordException("Confirm password is wrong!");
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter login");
            string login = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();
            Console.WriteLine("Confirm password:");
            string confirmPassword = Console.ReadLine();

            User user = new(login, password, confirmPassword);

            try
            {
                Login(user);
                Console.WriteLine("OK");
            }
            catch (WrongLoginException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WrongPasswordException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
