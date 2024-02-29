using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HomeWork08
{
    public class Dog : Animal,IAnimalAction
    {
        public Dog(string name) : base(name)
        {
            this.Name = name;
        }

        public override void Eat()
        {
            Console.WriteLine($"Собака {Name} ест");
        }

        public void Walk()
        {
            Console.WriteLine($"Собака {Name} гуяет");
        }

        public void Play(string joy)
        {
            Console.WriteLine($"Собака {Name} играет c {joy}");
        }
    }
}
