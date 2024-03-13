using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10work
{
    public abstract class Car : IVehicle
    {
        public double Fuel { get; set; }
        public double Consumption { get; set; }
        internal Car (double fuel, double consumption)
        {
            this.Fuel = fuel;
            this.Consumption = consumption;
        }
        public virtual bool Refuel(int gasoline)
        {
            throw new NotImplementedException();
        }

        public virtual void Drive(int distance)
        {
            throw new NotImplementedException();
        }
        public virtual void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
