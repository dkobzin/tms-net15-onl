namespace Lesson10Work;

public class SportCar(string name, int fuel, int consumption) : Car(name, fuel, consumption), IVehicle
{
    public bool isEnoughFuel => isEnoughFuelCar;
    
    public void Drive(int distance = 0)
    {
        DriveCar(distance);
        Console.WriteLine(isEnoughFuel ? $"{Name} is driven!" : $"{Name} have not enough fuel!");
    }

    public bool Refuel(int fuel)
    {
        RefuelCar(fuel);
        Console.WriteLine($"{Name} is refueled!");
        return isEnoughFuel;
    }
}
