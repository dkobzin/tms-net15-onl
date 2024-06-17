using BuisnessLayer.Dtos;
using DataAccessLayer.Entities;

namespace BuisnessLayer.Mappers;

public class UserMapper : IUserMapper
{
    public UserDto MapToModel(UserEntity entity)
    {
        return new UserDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Email = entity.Email,
            AskedWeatherForeCast = entity.AskedWeatherForeCast
        };
    }
    
    public UserEntity MapFromModel(UserDto user)
    {
        return new UserEntity
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            AskedWeatherForeCast = user.AskedWeatherForeCast
        };
    }
}