namespace Lesson12;

public class Animal(string name)
{
    public string Name { get; } = name;
}

class Bear(string name) : Animal(name) { }

class Camel(string name) : Animal(name) { }
public class Stack<T>   // A simple Stack implementation
    //: IPoppable<T>,
    //    IPushable<T>
{
    int position;
    T[] data = new T[100];
    public void Push (T obj)
    {
        Console.WriteLine($"{typeof(T)} push!");
        data[position++] = obj;
    }

    public T Pop()
    {
        Console.WriteLine($"{typeof(T)} pop!");
        return data[--position];
    }
}

public interface IPoppable<out T> { T Pop(); }

public interface IPushable<in T> { void Push (T obj); }
