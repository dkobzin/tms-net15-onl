namespace TasksLesson8;

using System;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A huge dog is sitting and doing something...\n");

        Dog dog = new();
        string dogName = ProgramHelpers.AskForName();
        dog.SetName(dogName);
        Console.WriteLine($"\nDog's name is: {dog.GetName()}");
        dog.Eat();

        Console.WriteLine("\nNow let's look at the cat in the far corner...\n");

        Cat cat = new();
        string catName = ProgramHelpers.AskForName();
        cat.SetName(catName);
        Console.WriteLine($"\nCat's name is: {cat.GetName()}");
        cat.Move();
        cat.MakeSound();
    }
}

