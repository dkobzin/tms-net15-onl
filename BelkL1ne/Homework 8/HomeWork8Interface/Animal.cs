using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8Interface
{
    interface Animal
    {
        public string Name { get; set; }

        public void GetName();

        public string SetName();

        public void Eat();
    }
}
