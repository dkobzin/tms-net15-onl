namespace Homework_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user = new User("BelkL1ne", "Cartoon12");
                Console.WriteLine(Login(user));
                if (!Login(user)) { throw new WrongPasswordException("Invalid password"); }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static bool Login(User user)
        {
            if (user.Password != user.ConfirmPassword)
            {
                return false;
                
            }
            return true;
        }
    }
}
