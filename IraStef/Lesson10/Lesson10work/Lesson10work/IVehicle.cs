using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10work
{
    public interface IVehicle
    {
        public  void Drive(int distance);

        public void Drive();
        public  bool Refuel(int gasoline);
    }
}
