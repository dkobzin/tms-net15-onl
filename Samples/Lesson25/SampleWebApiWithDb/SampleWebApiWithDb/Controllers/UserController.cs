using Microsoft.AspNetCore.Mvc;
using SampleWebApiWithDb.Models;
using SampleWebApiWithDb.Services;

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
        public User Get([FromQuery] Guid id)
        {
            return _userService.Get(id);
        }
        
        [HttpPost]
        public User Create([FromBody] User user)
        {
            user.Id =  _userService.Create(user);
            return user;
        }
        
        [HttpPut("{id:guid}")]
        public User Update([FromBody] User user)
        {
            _userService.Update(user);
            return user;
        }
        
        [HttpDelete("{id:guid}")]
        public void Delete([FromQuery] Guid id)
        {
            _userService.Delete(id);
        }

        [HttpGet]
        public IEnumerable<User> GetUsers([FromQuery] string userName)
        {
            var users = _userService.GetAll(userName);
            return users;
        }
    }
}
