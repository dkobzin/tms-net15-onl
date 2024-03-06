namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("������� ���������� ������� ��� ���������� SportsCar ");
            int petrolSportsCar = int.Parse(Console.ReadLine());
            Console.WriteLine("������� ���������� ������� ��� ��������� Truck");
            int petrolTruck = int.Parse(Console.ReadLine());

            Console.WriteLine("������� ���������� ��� �������");
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