using System.ComponentModel.DataAnnotations;
using Lesson11Attributes;

[AgeValidation(18)]
public class Person
{
    [Required(AllowEmptyStrings = false)]
    public string Name { get;}
    
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public bool IsValid()
    {
        var type = typeof(Person);
        var attributes = type.GetCustomAttributes(false);
        
        var isValid = false;
        foreach (Attribute attr in attributes)
        {
            if (attr is AgeValidationAttribute ageAttribute)
                isValid = Age >= ageAttribute.Age;
        }
        return isValid;
    }

    public List<ValidationResult> Validate()
    {
        var results = new List<ValidationResult>();
        var context = new ValidationContext(this);
        Validator.TryValidateObject(this, context, results, true);
        return results;
    }
}