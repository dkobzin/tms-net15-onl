using DataAccessLayer;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleWebApiWithDb.Mappers;
using SampleWebApiWithDb.Models;

namespace SampleWebApiWithDb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserMapper _userMapper;
        private readonly ApplicationDbContext _applicationDbContext;
        
        private readonly ILogger<WeatherForecastController> _logger;

        public UserController(ILogger<WeatherForecastController> logger, 
            IUserMapper userMapper, 
            ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _userMapper = userMapper;
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet(Name = "GetUsers")]
        public IEnumerable<User> Get()
        {
            var users = _applicationDbContext.Users
                    // Eager
                 .Include(p => p.Addresses)
                // Explicit
                //    .Load()
                .Skip(0)
                .Take(10)
                .ToList();


            return users
                .Select(userEntity => _userMapper.MapToModel(userEntity))
                .ToList();
        }
    }
}
