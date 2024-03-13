// See https://aka.ms/new-console-template for more information

public class Account
{
    public delegate void AccountHandler(string message);
    public event AccountHandler? Notify;
    
    public decimal Sum { get; private set; }

    public Account(decimal sum)
    {
        Sum = sum;
    }

    public void Put(decimal amount)
    {
        Sum += amount;
        Notify?.Invoke($"Your account has been credited {amount}");
    }
    
    public void Take(decimal amount)
    {
        Sum -= amount;
        Notify?.Invoke($"Your account has been taked {amount}");
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        var account = new Account(100);
        account.Notify += Console.WriteLine;

        account.Put(20);
        Console.WriteLine(account.Sum);

        account.Take(70);
        Console.WriteLine(account.Sum);

        Console.ReadLine();
    }
}