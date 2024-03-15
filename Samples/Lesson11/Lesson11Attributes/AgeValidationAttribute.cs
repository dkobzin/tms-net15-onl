namespace Lesson11Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class AgeValidationAttribute : Attribute
{
    public int Age { get;}
    public AgeValidationAttribute() { }
    public AgeValidationAttribute(int age) => Age = age;
}