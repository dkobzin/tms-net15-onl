namespace HW13
{
    internal class Program
    {
        static bool Login(User userToLogin)
        {
            try
            {
                userToLogin.CheckLogin();
                userToLogin.CheckPassword();
            }
            catch (WrongLoginException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (WrongPasswordException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            Console.WriteLine("Everything is OK! :)");
            return true;
        }
        static void Main(string[] args)
        {
            var bob = new User("bob", "12345678912345678900", "12345678912345678900");
            Console.WriteLine(Login(bob) ? "Login success" : "Login err");
        }
    }
}
