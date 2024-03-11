using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8Abstract
{
    internal class Dog : Animal
    {
        string? name;
        public override string Name { get; set; }
        public override void Eat()
        {
            Console.WriteLine($"{name} eat.");
        }
        public override void GetName()
        {
            Console.WriteLine(name);
        }

        public override string SetName()
        {
            Console.WriteLine("Name a Dog");
            name = Console.ReadLine();
            return name;
        }
    }
}
