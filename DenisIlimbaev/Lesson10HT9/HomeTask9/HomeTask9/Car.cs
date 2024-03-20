using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenisHT9
{

    internal abstract class Car : IVehicle
    {
        protected double fuel { get; set; }
        protected double consumption { get; set; }
        internal Car(double fuel, double consumption)
        {
            this.fuel = fuel;
            this.consumption = consumption;
        }
        void IVehicle.Drive()
        {
            if (fuel > 0) Console.WriteLine($"Автомобиль {this.GetType().Name} движется  ");
        }
        bool IVehicle.Refuel(uint colfuel)
        {
            fuel += colfuel;
            return true;
        }
    }
}
