using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08
{
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
            OperationEnum kind;
            while (true)
            {
                Console.WriteLine($"Please, select input for marks: 1 - {OperationEnum.Sum}, 2 - {OperationEnum.MaxMin}, 3 - {OperationEnum.Average}");
                if (!Enum.TryParse(Console.ReadLine(), out kind))
                {
                    Console.WriteLine("Please, select input for marks!");
                }
                break;
            }

            switch (kind)
            {
                case OperationEnum.Sum:
                {
                    var sum = marks.Sum();
                    Console.WriteLine($"Sum: {sum} ");
                    break;
                }
                case OperationEnum.MaxMin:
                {
                    var max = marks.Max();
                    var min = marks.Min();
                    Console.WriteLine($"Max: {max}, Min: {min} ");
                    break;
                }
                case OperationEnum.Average:
                {
                    var avg = marks.Average();
                    Console.WriteLine($"Average: {avg}");
                    break;
                }
                default:
                    Console.WriteLine("Incorrect operation!");
                    break;
            }
        }

        // It's get info with additional message
        internal string GetInfoWithAdditionalMessage(string message) => GetInfo() + message;

        internal string AdditionalMessage
        {
            get => AdditionalMessage;
            set => AdditionalMessage = value;
        }

        internal string GetAdditionalMessage() => AdditionalMessage;
        internal void SetAdditionalMessage() => AdditionalMessage = PersonConstants.AdditionalMessage;
    }
}
