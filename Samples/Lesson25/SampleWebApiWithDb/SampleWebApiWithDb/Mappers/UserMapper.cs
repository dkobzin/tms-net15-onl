using DataAccessLayer.Entities;
using SampleWebApiWithDb.Models;

namespace SampleWebApiWithDb.Mappers;

public class UserMapper : IUserMapper
{
    public User MapToModel(UserEntity entity)
    {
        return new User
        {
            Id = entity.Id,
            Name = entity.Name,
            Email = entity.Email,
            AskedWeatherForeCast = entity.AskedWeatherForeCast
        };
    }
    
    public UserEntity MapFromModel(User user)
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