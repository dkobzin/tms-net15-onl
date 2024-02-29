using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public abstract void Eat();
        
    }
}
