namespace TasksLesson8;

using TasksLesson8.Interfaces;

public class Cat : IMovable, ISound, INameable
{
    public string Name { get; set; } = "";

    public void Move()
    {
        Console.WriteLine($"{Name} moved in the darkness...");
    }

    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}