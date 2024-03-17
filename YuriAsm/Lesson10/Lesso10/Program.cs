
using Lesson10;

Console.WriteLine("Введите количество топлива");
int.TryParse(Console.ReadLine(), out var result);

IVechicle sportCar = new SportCar(result, 2);
IVechicle autoTruck = new Truck(result, 1);

sportCar.Drive();
autoTruck.Drive();



