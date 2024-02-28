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

    internal abstract class Person
    {
        internal abstract string FirstName { get; set; }
        internal abstract string LastName { get; set; }
        internal abstract DateTime DateOfBirth { get; set; }

        internal abstract string GetInfo();

        protected Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
    }

    internal class Student : Person
    {
        internal override string FirstName { get; set; }
        internal override string LastName { get; set; }
        internal override DateTime DateOfBirth { get; set; }

        internal override string GetInfo()
        {
            return new StringBuilder()
                .AppendFormat($"{nameof(FirstName)}:{FirstName}")
                .AppendFormat($"{nameof(LastName)}:{LastName}")
                .AppendFormat($"{nameof(DateOfBirth)}:{DateOfBirth.ToShortDateString()}")
                .ToString();
        }

        internal string Course { get; set; }

        internal decimal Price { get; set; }

        public Student(string firstName, string lastName, DateTime dateOfBirth, string course, decimal price)
            : base(firstName, lastName, dateOfBirth)
        {
            Course = course;
            Price = price;
        }

        public void DoSomething()
        {
            var marks = new List<int> { 5, 4, 5, 3, 2, 4, 5 };
            int kind;
            while (true)
            {
                Console.WriteLine("Please, select input for marks: 1 - Sum, 2 - Max and Min, 3 - Average");
                if (int.TryParse(Console.ReadLine(), out kind))
                {
                    if (kind != 1 & kind != 2 & kind != 3)
                    {
                        Console.WriteLine("Please, select input for marks!");
                        continue;
                    }

                    break;
                }

                continue;
            }

            if (kind == 1)
            {
                var sum = marks.Sum();
                Console.WriteLine($"Sum: {sum} ");
            }

            if (kind == 2)
            {
                var max = marks.Max();
                var min = marks.Min();
                Console.WriteLine($"Max: {max}, Min: {min} ");
            }

            if (kind == 3)
            {
                var avg = marks.Average();
                Console.WriteLine($"Average: {avg}");
            }
        }

        // It's get info with additional message
        internal string GetInfoWithAdditionalMessage(string Message) => GetInfo() + Message;

        internal string AdditionalMessage;

        internal string GetAdditionalMessage() => AdditionalMessage;
        internal void SetAdditionalMessage() => AdditionalMessage = "Additional Message";

    }
}
