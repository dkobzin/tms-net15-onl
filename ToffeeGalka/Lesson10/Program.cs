namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¬ведите количество бензина дл€ автомобил€ SportsCar ");
            int petrolSportsCar = int.Parse(Console.ReadLine());
            Console.WriteLine("¬ведите количество бензина дл€ атомобил€ Truck");
            int petrolTruck = int.Parse(Console.ReadLine());

            Console.WriteLine("¬ведите рассто€ние дл€ поездки");
            int distance = int.Parse(Console.ReadLine());


            Car sportcar = new SportsCar(petrolSportsCar, 8);
            sportcar.Refuel(petrolSportsCar);
            sportcar.Drive(distance);

            Car truck = new Truck(petrolTruck, 10);
            truck.Refuel(petrolTruck);
            truck.Drive(distance);
        }
    }
}