namespace Samples28.OCP;

public class User
{
    // It's not right
    public void Build() => Console.WriteLine(nameof(Build));
    public void Drive() => Console.WriteLine(nameof(Drive));
    public void Run() => Console.WriteLine(nameof(Run));
}