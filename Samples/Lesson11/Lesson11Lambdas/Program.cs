// See https://aka.ms/new-console-template for more information


Transformer sqr = x => x * x;

Console.WriteLine(sqr(3));

Action<int> print = Console.WriteLine;

print(25);

Predicate<int> isPositive = (int x) => x > 0;

Console.WriteLine(isPositive(-20));


Func<int, int> cube = c => c * c * c;

Console.WriteLine(cube(3));

Console.ReadLine();
delegate int Transformer(int i);
