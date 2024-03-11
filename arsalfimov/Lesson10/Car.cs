namespace Lesson10;

public abstract class Car(int initialFuel, int consumption) : IVehicle
{
    protected int fuelLevel = initialFuel;
    protected int fuelConsumption = consumption;

    public void Drive(int distance)
    {
        int fuelRequired = (distance / 100) * fuelConsumption;
        if (fuelLevel >= fuelRequired && fuelLevel > 0)
        {
            Console.WriteLine("The car is moving.");
            fuelLevel -= fuelRequired;
        }
        else if (fuelLevel == 0)
        {
            Console.WriteLine("The car can't move, it's out of fuel.");
        }
        else
        {
            Console.WriteLine("Not enough fuel to cover the distance.");
        }
    }

    public bool Refuel(int amount)
    {
        fuelLevel += amount;
        return true;
    }
}

