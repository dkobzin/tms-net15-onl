using DataAccessLayer;
using DataAccessLayer.Entities;
using WebApiWithDb.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiWithDb.Services
{
    public class UserService(ApplicationDbContext context) : IUserService
    {
        public async Task AddUser(string surName, string name, string secName, string email)
        {
            context.Add(new UserEntity
            {
                SurName = surName,
                Name = name,
                SecName = secName,
                Email = email,

            });
            await context.SaveChangesAsync();
        }
        public async Task<UserEntity> QueryUser()
        {
            var u = await context.Users.FirstOrDefaultAsync(UserEntity => UserEntity.Id == 2);
            return u;
           
        }
    }
}