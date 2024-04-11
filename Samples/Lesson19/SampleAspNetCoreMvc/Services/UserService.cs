using SampleAspNetCoreMvc.Models;

namespace SampleAspNetCoreMvc.Services;

public class UserService : IUserService
{
    private readonly IConfiguration _configuration;

    public UserService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public UserModel GetById(int id)
    {
        var user = new UserModel()
        {
            Id = 1,
            FirstName = "Bob"
        };
        return user;
    }

    public void Save(UserModel user)
    {
        
    }
}