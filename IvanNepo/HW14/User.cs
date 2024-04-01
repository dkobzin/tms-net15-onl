namespace HomeWork14_IvanNepo;
    using System;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    [NonSerialized]
    public string IDCard { get; set; }
}
