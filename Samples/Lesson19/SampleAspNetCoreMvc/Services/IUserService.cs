using SampleAspNetCoreMvc.Models;

namespace SampleAspNetCoreMvc.Services;

public interface IUserService
{
    UserModel GetById(int id);
    void Save(UserModel user);
}