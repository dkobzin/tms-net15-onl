class Program {
    static void Main(string[] args) {
        var a = new A(2) {B = 3};
        Console.Write(a.B);
        Console.ReadLine();
    }
}
public class A {
    public int B { get; set; }
    public A(int b) {
        Console.Write("1"); B = b;
    }
}