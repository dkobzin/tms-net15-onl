// See https://aka.ms/new-console-template for more information

using Lesson10Work;

ICollection<Car> cars = new List<Car>
{
    new SportCar(nameof(SportCar), 50, 10),
    new Truck(nameof(Truck), 150, 20)
};

foreach (var car in cars)
{
    var vehicle = (IVehicle) car;
    vehicle.Drive(100);
    if (!vehicle.isEnoughFuel)
        vehicle.Refuel(10);
}