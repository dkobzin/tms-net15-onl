namespace Lesson10Test;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var a1 = new A1();
            Console.Write("1");
            var a2 = new A2();
        }
        catch (Exception)
        {
            Console.Write("3");
        }
        Console.ReadLine();
    }
}
class A1
{
    public int B1;
}
class A2
{
    public int B2;
    public A2(int b2)
    {
        B2 = b2;
    }
}