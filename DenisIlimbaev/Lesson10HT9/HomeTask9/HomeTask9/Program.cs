using DenisHT9;

    internal class Program
    {
        static void Main()
        {
            Console.Write("Количество бензина: ");
            int.TryParse(Console.ReadLine(), out var result);
            IVehicle Fcar = new SportCar(result, 1);
            IVehicle SCar = new Truck(result, 2);
            Fcar.Drive();
            SCar.Drive();
        }
    }
