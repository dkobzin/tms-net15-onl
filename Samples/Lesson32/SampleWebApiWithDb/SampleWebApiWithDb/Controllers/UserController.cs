using BuisnessLayer.Dtos;
using BuisnessLayer.Services;
using Microsoft.AspNetCore.Mvc;
using SampleWebApiWithDb.Models;

namespace SampleWebApiWithDb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {  
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        [Route("{id:guid}")]
        public UserViewModel Get([FromQuery] Guid id)
        {
            var user = _userService.Get(id);
            return new UserViewModel
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                AskedWeatherForeCast = user.AskedWeatherForeCast
            };
        }
        
        [HttpPost]
        public UserViewModel Create([FromBody] UserViewModel userViewModel)
        {
            var user = new UserDto()
            {
                Id = userViewModel.Id,
                Name = userViewModel.Name,
                Email = userViewModel.Email,
                AskedWeatherForeCast = userViewModel.AskedWeatherForeCast
            };
            userViewModel.Id =  _userService.Create(user);
            return userViewModel;
        }
        
        [HttpPut("{id:guid}")]
        public UserViewModel Update([FromBody] UserViewModel userViewModel)
        {
            var user = new UserDto()
            {
                Id = userViewModel.Id,
                Name = userViewModel.Name,
                Email = userViewModel.Email,
                AskedWeatherForeCast = userViewModel.AskedWeatherForeCast
            };
            _userService.Update(user);
            return userViewModel;
        }
        
        [HttpDelete("{id:guid}")]
        public void Delete([FromQuery] Guid id)
        {
            _userService.Delete(id);
        }

        [HttpGet]
        public async Task<IEnumerable<UserViewModel>> GetUsers([FromQuery] string userName)
        {
            var dtos = await _userService.GetAll(userName);
            var users = dtos.Select( u => new UserViewModel
            {
                Id = u.Id, 
                Name = u.Name,
                Email = u.Email,
                AskedWeatherForeCast = u.AskedWeatherForeCast
            }).ToList();
            return users;
        }
    }
}
