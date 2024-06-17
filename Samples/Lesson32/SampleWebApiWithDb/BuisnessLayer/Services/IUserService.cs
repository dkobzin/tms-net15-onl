using BuisnessLayer.Dtos;

namespace BuisnessLayer.Services;

public interface IUserService
{
    UserDto Get(Guid? id);
    void Update(UserDto user);
    Guid Create(UserDto user);
    void Delete(Guid id);
    Task<IEnumerable<UserDto>> GetAll(string userName);
}