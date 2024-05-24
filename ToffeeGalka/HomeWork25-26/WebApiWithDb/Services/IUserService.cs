using DataAccessLayer.Entities;
using WebApiWithDb.Models;

namespace WebApiWithDb.Services
{
    public interface IUserService
    {
        public Task AddUser(string surName, string name, string secName, string email);
        public Task<UserEntity> QueryUser();
    }
}
