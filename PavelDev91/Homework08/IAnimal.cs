using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework08
{
    public interface IAnimal
    {
        string Name { get; set; }

        void SetName(string name);

        string GetName();

        string Eat();
    }
}
