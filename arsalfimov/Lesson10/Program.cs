namespace Lesson10;

public static class Program
{
    static void Main(string[] args)
    {
        SportsCar sportsCar = new SportsCar(0, 10);
        Truck truck = new Truck(0, 15);            

        Console.Write("Enter the amount of fuel to refuel the sports car: ");
        int fuelForSportsCar = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the amount of fuel to refuel the truck: ");
        int fuelForTruck = Convert.ToInt32(Console.ReadLine());

        sportsCar.Refuel(fuelForSportsCar);
        truck.Refuel(fuelForTruck);

        Console.WriteLine("\nDriving the sports car:");
        sportsCar.Drive(100);
        Console.WriteLine("\nDriving the truck:");
        truck.Drive(100);
    }
}