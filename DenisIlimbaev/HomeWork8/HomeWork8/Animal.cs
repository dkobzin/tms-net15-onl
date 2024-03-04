using System.Xml.Linq;
using static System.Console;
namespace HomeWork8
{
    internal abstract class Animal
    {
        // я думаю что сделать хоть какую-то реализацию стоит поэтому я использую virtual
        // Eat
        internal virtual void ActionAnimal(String action) => WriteLine($"{this.GetType().Name} with name {Name} {action}");

        // В созданиии методов GetName и SetName не смысла так как компилятор и так создаст 
        // set_Name и get_Name
        internal virtual String? Name { get; set; }

    }
    interface IAnimal
    {
        internal void ActionAnimal(String action);
    }
    internal class Dog : Animal, IAnimal
    {
        // Можно допустить конструктор без аргументов в классе Program объяснение
        internal Dog() { }
        internal Dog(String name) => Name = name;
        internal override void ActionAnimal(String action)
        {
            // или так WriteLine("dog with name {Name ?? "umknown"} {action}");
            base.ActionAnimal(action);
        }

        void IAnimal.ActionAnimal(string action)
        {
            base.ActionAnimal(action);
        }
    }
}
