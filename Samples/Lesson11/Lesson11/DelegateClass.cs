namespace Lesson11;
public delegate void DelegateMessage(string message);

public class DelegateClass
{
    public void PrintMessage(int parameter, DelegateMessage callback)
    {
        callback.Invoke($"Calling delegate {nameof(DelegateMessage)} with parameter {parameter} ");
    }
}