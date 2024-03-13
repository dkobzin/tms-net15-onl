namespace Lesson10;

public abstract class Car(int initialFuel, int consumption) : IVehicle
{
    // Конструктор класса Car
    public void Drive(int distance)
    {
        var fuelNeeded = distance * consumption;
        if (initialFuel >= fuelNeeded)
        {
            Console.WriteLine("Машина поехала!");
            initialFuel -= fuelNeeded;
        }
        else
        {
            Console.WriteLine("Недостаточно топлива!");
        }
    }
    public bool Refuel(int amount)
    {
        initialFuel += amount;
        return true;
    }
}