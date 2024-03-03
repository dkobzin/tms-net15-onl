using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HW8
{
    internal class DogInterface : IHaveName, INameGettable, INameSettable, IEatable
    {
        public string Name { get; set; }

        public void Eat() => Console.WriteLine($"Собака {Name} ест (интерфейс)");

        public string GetName() => Name;

        public void SetName(string name) => Name = name;
    }
}
