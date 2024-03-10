namespace Lesson10
{
    public abstract class Car : IVechicle
    {
        public int Fuel {  get; set; }
        public int Consumption { get; set; }

        public Car(int fuel, int consumption)
        {
            Fuel = fuel;  
            Consumption = consumption;
        }

        void IVechicle.Drive()
        {
            if (Fuel > 0)
                Console.WriteLine($"Автомобиль {GetType().Name} едет");
            else Console.WriteLine("Кончилось топливо");
        }

        bool IVechicle.Refuel(int quantity)
        {

            Fuel += quantity;
            return true;
        }
    }
    
}
