using Нome_work_8;

Dog dog = new Dog();
Console.WriteLine("Как зовут собаку?");
dog.Name = Console.ReadLine();
Console.Write($"{dog.Name} ");
dog.Eat();

