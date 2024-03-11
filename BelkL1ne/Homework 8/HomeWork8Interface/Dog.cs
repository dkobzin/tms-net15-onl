using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8Interface
{
    class Dog : Animal
    {
        string? name;
        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine($"{name} eat.");
        }
        public void GetName()
        {
            Console.WriteLine(name);
        }

        public string SetName()
        {
            Console.WriteLine("Name a Dog");
            name = Console.ReadLine();
            return name;
        }
    }
}
