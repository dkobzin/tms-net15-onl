using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lesson08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var person = new Person();
            var student = new Student("Frank", "Underwood", 
                new DateTime(1953, 1, 1), "Military Science", 10000);
            Console.WriteLine(student.GetInfo());
            student.DoSomething();
            Console.ReadLine();
        }
    }

}
