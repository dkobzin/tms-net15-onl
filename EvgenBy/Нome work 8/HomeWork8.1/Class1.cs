using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8._1
{

    internal class Dog : IAnimal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.Write("Ест мясо и ростительную пищу");
        }
    }
}
