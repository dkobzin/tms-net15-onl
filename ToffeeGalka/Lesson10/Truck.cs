using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    internal class Truck : Car
    {
        public Truck(int petrol, int consumption) : base(petrol, consumption)
        {
            this.Petrol = petrol = 0;
            this.Consumption = consumption;
        }
        public override void Drive(int distance)
        {
            double gasdistance = distance / Consumption;

            if (Petrol > 0)
            {
                if (gasdistance <= Petrol)
                {
                    Console.WriteLine("Truck проехал все расстояние\n");
                }
                else if (gasdistance > Petrol)
                {
                    Console.WriteLine($"Truck проедет не все расстояние\n");
                }
            }
            else
            {
                Console.WriteLine("Truck не поедет - нет бензина!\n");
            }
        }
        public override bool Refuel(int petrol)
        {
            Petrol += petrol;
            Console.WriteLine($"Truck заправили на {petrol} литров. Общее количество бензина в баке {Petrol} литров!");
            return true;
        }
    }
}
