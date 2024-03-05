using Lesson10work;

Console.WriteLine("Введите количество бензина для автомобиля SportCar:");
int.TryParse(Console.ReadLine(), out var resultSportCar);
IVehicle carSportCar = new SportCar(resultSportCar, 1);
carSportCar.Drive();

Console.WriteLine("Введите количество бензина для автомобиля Truck:");
int.TryParse(Console.ReadLine(), out var resultTruck);
IVehicle carTruck = new Truck(resultTruck, 2);
carTruck.Drive();


