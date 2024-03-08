using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8Abstract
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public abstract void GetName();

        public abstract string SetName();

        public abstract void Eat();

    }
}
