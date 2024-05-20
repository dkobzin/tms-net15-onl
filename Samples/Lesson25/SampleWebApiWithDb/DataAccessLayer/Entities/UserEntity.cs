namespace DataAccessLayer.Entities;

public class UserEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime AskedWeatherForeCast { get; set; }

    public Guid AddressId { get; set; }
    // public AddressEntity Address { get; set; }
    public virtual ICollection<AddressEntity> Addresses { get; set; } // vurtual is need to lazy loading

    public UserEntity()
    {
        Addresses = new List<AddressEntity>();
    }
}