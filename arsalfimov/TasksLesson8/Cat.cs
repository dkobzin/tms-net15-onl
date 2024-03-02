namespace TasksLesson8;

using TasksLesson8.Interfaces;

public class Cat : IMovable, ISound, INameable
{
    protected string Name { get; private set; } = "";
    public string GetName() => Name;
    public void SetName(string name) => Name = name;

    public void Move()
    {
        Console.WriteLine($"{GetName()} moved in the darkness...");
    }

    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}