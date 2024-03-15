namespace Lesson12;

public class Company<T> where T: class
{
    public T Ceo { get; set; }

    public Company(T ceo)
    {
        Ceo = ceo;
    }
}