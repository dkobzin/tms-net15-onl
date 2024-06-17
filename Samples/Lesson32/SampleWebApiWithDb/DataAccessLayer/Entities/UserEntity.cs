namespace DataAccessLayer.Entities;

public class UserEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime AskedWeatherForeCast { get; set; }
}