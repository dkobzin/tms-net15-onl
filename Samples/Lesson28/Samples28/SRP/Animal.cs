namespace Samples28.SRP;

// It's good
public class Animal(string type)

// It's not good
//public abstract class Animal(string type)
{
    public void Eat() => Console.WriteLine($"{Type}.{nameof(Eat)}");

    public string Type { get; set; } = type;

    // It's not good
    // 
    // public void Swim() => Console.WriteLine($"{nameof(Animal)}.{nameof(Swim)});
    // public void Run() => Console.WriteLine($"{nameof(Animal)}.{nameof(Run)});
    // public void Fly() => Console.WriteLine($"{nameof(Animal)}.{nameof(Fly)});

    // It's good
    public virtual void Swim() => Console.WriteLine($"{nameof(Animal)}.{nameof(Swim)}");
    public virtual void Run() => Console.WriteLine($"{nameof(Animal)}.{nameof(Run)}");
    public virtual void Fly() => Console.WriteLine($"{nameof(Animal)}.{nameof(Fly)}");

}