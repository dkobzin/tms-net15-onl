using HomeWork8._1;

Dog dog = new Dog();
Console.WriteLine("Как зовут вашу собаку");
dog.Name = Console.ReadLine();
Console.Write(dog.Name + ' ');
dog.Eat();