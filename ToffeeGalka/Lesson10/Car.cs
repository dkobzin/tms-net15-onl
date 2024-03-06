using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public abstract class Car : IVehicle
    {
        public int Petrol { get; set; }
        public int Consumption { get; set; }
        public Car (int petrol, int consumption)
        {
           this.Petrol = petrol;
           this.Consumption = consumption;
        }
        public abstract void Drive(int distance);
        public abstract bool Refuel(int petrol);      
    }
}
