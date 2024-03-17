using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Нome_work_8
{
    public class Dog : Animal, IAnimal
    {
        // Реализация абстрактного метода Eat
        public override void Eat()
        {
            Console.WriteLine("Собака ест.");
        }

        // Реализация метода MakeSound
        public void MakeSound()
        {
            Console.WriteLine("Гав-гав!");
        }

        // Реализация метода Move
        public void Move()
        {
            Console.WriteLine("Бежит.");
        }
    }
}
