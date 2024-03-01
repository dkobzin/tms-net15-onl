using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public Cat(string name)
        {
           Name = name;
        }
        public void Eat()
        { 
         Console.WriteLine($"Кот {Name} ест");
        }

    }
}
