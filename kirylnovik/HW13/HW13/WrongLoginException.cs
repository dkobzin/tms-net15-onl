namespace HW13;

public class WrongLoginException : Exception
{
    public WrongLoginException() { }
    public WrongLoginException(string message) : base(message) { }
}