namespace HW8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как назвать собаку?");
            string dogName;
            while (true)
            {
                dogName = Console.ReadLine();
                if (!string.IsNullOrEmpty(Console.ReadLine())) break;
                Console.WriteLine("Введите кличку собаки корректно");
            }

            var absDog = new Dog();
            var interDog = new DogInterface();

            absDog.SetName(dogName);
            interDog.SetName(dogName);

            Console.WriteLine($"Кличка собаки: {absDog.GetName()}");
            Console.WriteLine($"Кличка собаки(интерфейс): {interDog.GetName()}");

            absDog.Eat();
            interDog.Eat();

        }
    }
}
