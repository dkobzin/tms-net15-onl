namespace HW8;

public interface IAnimal
{
    string Name { get; set; }
    void SetName(string name);
    string GetName();
    void Eat();
}