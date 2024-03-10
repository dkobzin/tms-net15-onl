using System.Threading.Channels;


namespace HomeworkLesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Назовите собаку:");
            string DogName = Console.ReadLine();

            Dog dog = new Dog();

            dog.SetName(DogName);

            dog.GetName();
            
            dog.Eat();
        }
    }
}
