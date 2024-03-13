namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кличка собаки/кота?");
            string name = Console.ReadLine();

            Animal dog = new Dog(name);
            dog.Eat();
            
            Cat cat = new Cat(name);
            var icat = (IAnimal)cat;
            icat.Eat();
        }
    }
}
