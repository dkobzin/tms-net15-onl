using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10work
{
    internal class SportCar : Car
    {
        internal SportCar(double fuel, double consumption) : base(fuel, consumption) { }
        public override void Drive(int distance)
        {
            if (Fuel > 0) Console.WriteLine($"Автомобиль {GetType().Name} движется");
            else Console.WriteLine($"Автомобиль {GetType().Name} стоит");
        }
        public override void Drive() 
        {
            Drive(0);
        }
        public override bool Refuel(int gasoline)
        {
            Fuel += gasoline;
            return true;
        }
    }
}
