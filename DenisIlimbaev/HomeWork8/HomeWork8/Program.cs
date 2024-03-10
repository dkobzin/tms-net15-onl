using HomeTask8;
class Work
{
    static void Main()
    {
        try
        {
            Console.Write("Введите имя собаки: ");
            String? nameOfDog = Console.ReadLine();
            if(String.IsNullOrEmpty(nameOfDog)) { throw new Exception("вы не присвоили имя"); }
            Animal animal = new Dog(nameOfDog);
            /*
            или так:
            Animal dog = new Dog() 
            { 
                Name = nameOfDog
            };
            */
            animal.ActionAnimal("eat");
            IAnimal animal1 = new Dog()
            {
                Name = nameOfDog
            };
            animal1.ActionAnimal("eat");
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
