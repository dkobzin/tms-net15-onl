namespace HW13;

public class WrongPasswordException : Exception
{
    public WrongPasswordException() { }
    public WrongPasswordException(string message) : base(message) { }
}