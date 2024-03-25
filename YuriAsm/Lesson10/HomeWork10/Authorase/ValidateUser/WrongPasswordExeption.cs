namespace HomeWork10.Authorase.ValidateUser
{
    public class WrongPasswordExeption : Exception
    {
        public WrongPasswordExeption() { }
        
        public WrongPasswordExeption(string messege) : base() { }
        
    }
}
