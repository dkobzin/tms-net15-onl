using System.Text;

namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            var sportsCar = new SportsCar(0);
            var truck = new Truck(0);

            Console.WriteLine("Введите количество бензина для заправки");
            int fuelToAdd = int.Parse(Console.ReadLine());

            sportsCar.Refuel(fuelToAdd);
            truck.Refuel(fuelToAdd);

            sportsCar.Drive(50); // Можно изменить растояние
            truck.Drive(30); //Можно изменить растояни

            Console.ReadLine();
        }
    }
}
