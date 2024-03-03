using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson8
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }
        
        public abstract void Eat();
        
        public void GetName()
        {
            Console.WriteLine($"Собаку зовут: {Name}"); 
        }



    }
}
