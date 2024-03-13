
using Lesson11;

void PrintMessage(string message)
{
    Console.WriteLine($"{nameof(PrintMessage)} calling with {message}");
}

var delegateMessage = new DelegateMessage(Console.WriteLine);

var delegateClass = new DelegateClass();
delegateClass.PrintMessage(1, delegateMessage);

delegateMessage += PrintMessage;

delegateClass.PrintMessage(1, delegateMessage);
