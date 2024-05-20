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
}