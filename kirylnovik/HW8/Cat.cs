namespace HW8;

public class Cat : IAnimal
{
    public string Name { get; set; }

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} принимает пищу.");
    }
}