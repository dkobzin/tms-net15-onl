using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZLesson8
{
    public class Dog : Animal, IAnimal 
    {
        public override string Name { get; set; }

        public Dog(string name) : base(name) { }
        public override void Eat()
        {
            Console.WriteLine($"Собака {Name} ест");
        }

        public void Run()
        {
            Console.WriteLine($"Собака {Name} бегает");
        }
    }

}
