namespace HW8;

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine($"{Name} принимает пищу.");
    }
}