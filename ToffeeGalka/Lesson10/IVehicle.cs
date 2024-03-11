using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public interface IVehicle
    {
        public void Drive(int distance);
        public bool Refuel(int petrol); 
    }
}
