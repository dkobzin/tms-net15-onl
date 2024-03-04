namespace ConsoleApp1;
using System;

interface IVehicle
{
    void Drive(int distance);
    bool Refuel(int amount);
}

abstract class Car : IVehicle
{
    protected int fuelLevel;
    protected int fuelConsumption;

    public Car(int initialFuel, int consumption)
    {
        fuelLevel = initialFuel;
        fuelConsumption = consumption;
    }

    public void Drive(int distance)
    {
        int fuelNeeded = distance * fuelConsumption;
        if (fuelLevel >= fuelNeeded)
        {
            fuelLevel -= fuelNeeded;
            Console.WriteLine($"Проехали {distance} км.");
        }
        else
        {
            Console.WriteLine("Недостаточно топлива для поездки.");
        }
    }

    public bool Refuel(int amount)
    {
        fuelLevel += amount;
        Console.WriteLine($"Добавлено {amount} л топлива. Текущий уровень: {fuelLevel} л.");
        return true;
    }
}

class SportsCar : Car
{
    public SportsCar(int initialFuel, int consumption) : base(initialFuel, consumption)
    {
    }
}

class Truck : Car
{
    public Truck(int initialFuel, int consumption) : base(initialFuel, consumption)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        SportsCar sportsCar = new SportsCar(50, 10);
        Truck truck = new Truck(100, 5);

        Console.WriteLine("SportsCar:");
        sportsCar.Drive(100);
        sportsCar.Refuel(20);

        Console.WriteLine("\nTruck:");
        truck.Drive(200);
        truck.Refuel(50);
    }
}
