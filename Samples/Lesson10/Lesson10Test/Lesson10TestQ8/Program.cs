class Program {
    static void Main(string[] args) {
        var b = new B();
        var c = new C();
        Console.WriteLine(b.Sum(2, 3));
        Console.WriteLine(c.Sum(2, 3));
        Console.ReadLine();
    }
}
class A {
    public virtual int Sum(int a, int b) {
        return a + b;
    }
}
class B : A {
}
class C : A {
    public override int Sum(int a, int b) {
        return a + b + 1;
    }
}