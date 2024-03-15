namespace DZLesson13
{
    public class WrongLoginException : Exception 
    {
        public WrongLoginException(string message)
            : base(message) { }
        public WrongLoginException()
            : base() { }
    }  
}
