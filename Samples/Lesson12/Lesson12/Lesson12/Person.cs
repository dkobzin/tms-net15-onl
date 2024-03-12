namespace Lesson12;

public class Person(object id, string name, int age)
{
    public object Id { get;} = id;
    public string Name { get;} = name;
    public int Age { get; } = age;
}