// See https://aka.ms/new-console-template for more information


Transformer sqr = x => x * x;

Console.WriteLine(sqr(3));

Action<int> print = Console.WriteLine;

print(25);

var condition = 0;

Predicate<int> isPositive = (int x) =>
{
    var tempCondition = condition;
    return x > tempCondition;
};

Console.WriteLine(isPositive(-20));


Func<int, int> cube = c => c * c * c;

Console.WriteLine(cube(3));

Console.ReadLine();
delegate int Transformer(int i);
