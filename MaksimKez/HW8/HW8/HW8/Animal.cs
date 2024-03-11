using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal abstract class Animal
    {
        internal abstract string Name { get; set; }

        //Не особо понимаю зачем делать следующие методы если Name и так свойство
        internal abstract void SetName(string name);
        internal abstract string GetName();
        internal abstract void Eat();
    }
}
