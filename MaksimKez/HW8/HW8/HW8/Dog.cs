using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HW8
{
    internal class Dog : Animal
    {
        internal override string Name { get; set; }
        internal override void Eat() => Console.WriteLine($"Собака {Name} ест:)");
        internal override string GetName() => Name;
        internal override void SetName(string name) => Name = name;
    }
}
