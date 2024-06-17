using System.ComponentModel.DataAnnotations;
using AutoFixture;
using BuisnessLayer.Dtos;
using BuisnessLayer.Mappers;
using BuisnessLayer.Services;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using FluentAssertions;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Moq;

namespace BuisnessLayer.Tests.Services;

[TestFixture]
public class UserServiceTests
{
    private IUserService _underTest;
    private Mock<IUserMapper> _mapperMock;
    private Mock<IRepository<UserEntity>> _repositoryMock;
    private UserEntity _userEntity;
    private UserDto _userDto;
    private Fixture _fixture;

    [SetUp]
    public void SetUp()
    {
        _fixture = new Fixture();
        _userEntity = _fixture.Create<UserEntity>();
        _userDto = new UserDto()
        {
            Id = _userEntity.Id,
            Name = _userEntity.Name,
            Email = _userEntity.Email,
            AskedWeatherForeCast = _userEntity.AskedWeatherForeCast
        };
        _mapperMock = new Mock<IUserMapper>();
        _repositoryMock = new Mock<IRepository<UserEntity>>();
        _underTest = new UserService(_mapperMock.Object, _repositoryMock.Object);
    }

    [TearDown]
    public void TearDown()
    {
    }

    [Test]
    public void InitUserNotNull_WhenGet_ThenUserDtoIsNotEmpty()
    {
        // Arrange
        var expected = _userDto;

        _repositoryMock.Setup(p => p.Read(It.IsAny<Guid>()))
            .Returns(_userEntity);

        _mapperMock.Setup(p => p.MapToModel(It.IsAny<UserEntity>()))
            .Returns(_userDto);
        
        // Act
        var result = _underTest.Get(_userEntity.Id);

        // Assert
        result.Should()
            .NotBeNull()
            .And
            .BeOfType<UserDto>()
            .And
            .BeEquivalentTo(expected);
    }
    
    
    [TestCase("E9C49675-F2DA-4E6C-9438-88C4B7A28C31")]
    [TestCase("4111011F-D2B2-43DA-A25F-EAB86D94A973")]
    public void InitUserNotNull_WhenGetWithIdNotNull_ThenUserDtoIsNotEmpty(string id)
    {
        // Arrange
        var expected = _userDto;

        var guid = Guid.Parse(id);
        _repositoryMock.Setup(p => p.Read(It.IsAny<Guid>()))
            .Returns(_userEntity);

        _mapperMock.Setup(p => p.MapToModel(It.IsAny<UserEntity>()))
            .Returns(_userDto);
        
        // Act
        var result = _underTest.Get(_userEntity.Id);

        // Assert
        result.Should()
            .NotBeNull()
            .And
            .BeOfType<UserDto>()
            .And
            .BeEquivalentTo(expected);
    }

    [Test]
    public void InitUserNotNull_WhenGetIdIsNull_ThenThrowArgumentNullException()
    {
        // Act
        var act = () => _underTest.Get(null);

        // Assert
        act.Should().ThrowExactly<ArgumentNullException>();
    }

    [Test]
    public void InitUserNull_WhenGetIdIsNotNull_ThenThrowInvalodOperationException()
    {
        // Act
        var act = () => _underTest.Get(It.IsAny<Guid>());

        // Assert
        act.Should().ThrowExactly<InvalidOperationException>();
    }

    [Test]
    public async Task InitUsersNotNull_WhenGetAll_ThenUserDtosIsNotEmpty()
    {
        // Arrange
        var expected = new List<UserDto>() { _userDto };

        var entities = new List<UserEntity> { _userEntity};

        _repositoryMock.Setup(p => p.GetAll(It.IsAny<string>()))
            .Returns(entities.AsQueryable());
            
        _mapperMock.Setup(p => p.MapToModel(It.IsAny<UserEntity>()))
            .Returns(_userDto);

        // Act
        var result = await _underTest.GetAll(_userEntity.Name);

        // Assert
        result.Should()
            .NotBeNull();


    }

}