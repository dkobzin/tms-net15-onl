using BuisnessLayer.Dtos;
using DataAccessLayer.Entities;

namespace BuisnessLayer.Mappers;

public interface IUserMapper
{
    UserDto MapToModel(UserEntity entity);
    UserEntity MapFromModel(UserDto user);
}