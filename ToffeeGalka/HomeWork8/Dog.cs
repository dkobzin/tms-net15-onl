using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            this.Name = name;
        }
        public override void Eat()
        { 
            Console.WriteLine($"Собака {Name} ест");
        }

    }
}
