namespace TasksLesson8;

using TasksLesson8.Interfaces;

public class Cat : IMovable, ISound, INameable
{
    private string _name = "";

    public string GetName() => _name;
    public void SetName(string name) => _name = name;

    public void Move()
    {
        Console.WriteLine($"{GetName()} moved in the darkness...");
    }

    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}