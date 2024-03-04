using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public abstract class Car: IVehicle
    {
        private int _fuelLevel;
        private readonly int _fuelConsumption;

        public Car(int fuelLevel, int fuelConsumption)
        {
            _fuelLevel = fuelLevel;
            _fuelConsumption = fuelConsumption;
        }

        public void Drive(int distance)
        {
            if (_fuelLevel > 0)
            {
                Console.WriteLine("Автомобиль движется.");
                _fuelLevel -= distance * _fuelConsumption;

            }
            else
            {
                Console.WriteLine("Недостаточно топлива для поездки");
            }
        }

        public bool Refuel(int amount)
        {
            _fuelLevel += amount;
            return true;
        }
    }
}
