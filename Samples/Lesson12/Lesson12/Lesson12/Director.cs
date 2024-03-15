namespace Lesson12;

public class Director<T, K>  
{
    public T Id { get; }
    public K Email { get; }

    public Director(T id, K email)
    {
        Id = id;
        Email = email;
    }
}