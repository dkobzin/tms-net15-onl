namespace Нome_work_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Спросим у пользователя имя собаки
            Console.WriteLine("Введите имя собаки: ");
            string dogName = Console.ReadLine();

            // Создаем объект типа Dog
            Dog dog = new Dog();

            // Устанавливаем имя и выводим его
            dog.SetName(dogName);
            Console.WriteLine($"Имя собаки: {dog.GetName()}");

            // Вызываем методы Eat, MakeSound и Move
            dog.Eat();
            dog.MakeSound();
            dog.Move();
        }
    }
    
}
