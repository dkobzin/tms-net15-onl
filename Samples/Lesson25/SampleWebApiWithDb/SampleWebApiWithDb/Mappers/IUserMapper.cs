using DataAccessLayer.Entities;
using SampleWebApiWithDb.Models;

namespace SampleWebApiWithDb.Mappers;

public interface IUserMapper
{
    User MapToModel(UserEntity entity);
}