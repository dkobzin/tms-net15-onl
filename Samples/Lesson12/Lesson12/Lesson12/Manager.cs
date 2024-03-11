namespace Lesson12;

public class Manager<T> : PersonGeneric<T>
{
    public string Email { get; }

    public Manager(T id, string name, string email) : base(id, name)
    {
        Email = email;
    }
}