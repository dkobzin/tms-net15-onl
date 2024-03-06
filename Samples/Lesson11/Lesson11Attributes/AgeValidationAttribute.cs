namespace Lesson11Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
public class AgeValidationAttribute : Attribute
{
    public int Age { get;}
    public AgeValidationAttribute() { }
    public AgeValidationAttribute(int age) => Age = age;
}