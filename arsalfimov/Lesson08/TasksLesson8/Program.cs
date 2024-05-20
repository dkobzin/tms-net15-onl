namespace TasksLesson8;

using System;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A huge dog is sitting and doing something...\n");

        Dog dog = new();
        var dogName = ProgramHelpers.AskForName();
        dog.Name = dogName;
        Console.WriteLine($"\nDog's name is: {dog.Name}");
        dog.Eat();

        Console.WriteLine("\nNow let's look at the cat in the far corner...\n");

        Cat cat = new();
        var catName = ProgramHelpers.AskForName();
        cat.Name = catName;
        Console.WriteLine($"\nCat's name is: {cat.Name}");
        cat.Move();
        cat.MakeSound();
    }
}

