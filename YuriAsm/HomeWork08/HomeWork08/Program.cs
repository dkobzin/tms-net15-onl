using HomeWork08;



Console.WriteLine("Введите имя собаки");
var dogsName = Console.ReadLine();
var dog = new Dog(dogsName);
dog.Eat();

dog.Walk();

Console.WriteLine("Ввеите название игрушки для собаки");

string joy = Console.ReadLine();

dog.Play(joy);


