namespace Lesson12;

public static class Transformer
{
    public static TOut TransformToManager<TIn, TOut>(TIn person, string email) 
        where TIn: PersonGeneric<string>
        where TOut : Manager<string>
    {
        return (TOut)new Manager<string>(person.Id, person.Name, email);
    }
}