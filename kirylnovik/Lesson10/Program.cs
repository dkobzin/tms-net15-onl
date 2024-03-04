using Lesson10;

var sportsCar = new SportsCar(0, 10);
var truck = new Truck(0, 15); 


Console.Write("Введите количество топлива для заправки в спортивный автомобиль: ");
var fuelForSportsCar = int.Parse(Console.ReadLine());

Console.Write("Введите количество топлива для заправки в грузовик: ");
var fuelForTruck = int.Parse(Console.ReadLine());

sportsCar.Refuel(fuelForSportsCar);
truck.Refuel(fuelForTruck);

Console.WriteLine("Спортивный автомобиль:");
sportsCar.Drive(10); 
Console.WriteLine("Грузовик:");
truck.Drive(100);     