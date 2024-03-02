namespace HW8;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Назовите свою собаку: ");
        var dogName = Console.ReadLine();
        
        Console.Write("Назовите свою кошку: ");
        var catName = Console.ReadLine();

        Animal dog = new Dog();
        dog.SetName(dogName);
        
        IAnimal cat = new Cat();
        cat.SetName(catName);

        dog.Eat();
        cat.Eat();
    }
}