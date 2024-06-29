using BuisnessLayer.Dtos;
using BuisnessLayer.Mappers;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.Configuration;

namespace BuisnessLayer.Services;

public class UserService : IUserService
{
    private IUserMapper _mapper;
    private IRepository<UserEntity> _repository;
    private IConfiguration _configuration;
    public UserService(IUserMapper mapper, IRepository<UserEntity> repository, IConfiguration configuration)
    {
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _configuration = configuration ?? throw new ArgumentNullException(nameof(_configuration));
    }

    public UserDto Get(Guid? id)
    {
        if (id == null)
        {
            throw new ArgumentNullException(nameof(id));
        }
        var entity = _repository.Read(id.Value);

        if (entity == null)
        {
            throw new InvalidOperationException(nameof(entity));
        }
        return _mapper.MapToModel(entity);
    }

    public void Update(UserDto user)
    {
        var entity = _mapper.MapFromModel(user);
        _repository.Update(entity);
    }

    public Guid Create(UserDto user)
    {
        var entity = _mapper.MapFromModel(user);
        _repository.Create(entity);
        return entity.Id;
    }

    public void Delete(Guid id)
    {
        _repository.Delete(id);
    }

    public async Task<IEnumerable<UserDto>> GetAll(string userName)
    {
        var users = _repository.GetAll(userName).ToList();
        return await Task.FromResult(users.Select(userEntity => _mapper.MapToModel(userEntity)).ToList());
    }

    public string GetValueByKey(string key)
    {
        var section = _configuration.GetSection(key);
        if (section != null)
        {
            return section.Value!;
        }

        return string.Empty;
    }
}