using DZLesson8;

Console.WriteLine("Введите имя собаки");
string name = Console.ReadLine();
Dog dog = new Dog(name);
dog.Eat();
dog.Run();