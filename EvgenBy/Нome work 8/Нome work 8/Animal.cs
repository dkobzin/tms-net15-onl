using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Нome_work_8
{
    public abstract class Animal
    {
        // Свойство Name
        public string Name { get; set; }

        // Метод для установки имени
        public void SetName(string name)
        {
            Name = name;
        }

        // Метод для получения имени
        public string GetName()
        {
            return Name;
        }

        // Абстрактный метод для еды
        public abstract void Eat();
    }
}
