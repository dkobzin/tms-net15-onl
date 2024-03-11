namespace Lesson12;

public class PersonGeneric<T>
{
    public T Id { get; }
    public string Name { get; }
    public PersonGeneric(T id, string name)
    {
        Id = id; 
        Name = name;
    }
}