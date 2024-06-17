namespace SampleWebApiWithDb.Models;

public class UserViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime AskedWeatherForeCast { get; set; }
}