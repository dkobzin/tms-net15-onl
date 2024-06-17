using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories;

public class UserRepository(ApplicationDbContext dbContext) : IRepository<UserEntity>
{
    private readonly ApplicationDbContext _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

    public Guid Create(UserEntity entity)
    {
        var user = _dbContext.Users.Add(entity);
        _dbContext.SaveChanges();
        return user.Entity.Id;
    }

    public void Update(UserEntity entity)
    {
        _dbContext.Users.Update(entity);
        _dbContext.SaveChanges();
    }

    public UserEntity Read(Guid id)
    {
        var user = _dbContext.Users.FirstOrDefault(p => p.Id == id);
        return user!;
    }

    public void Delete(Guid id)
    {
        var user = _dbContext.Users.FirstOrDefault(p => p.Id == id);
        _dbContext.Users.Remove(user!);
        _dbContext.SaveChanges();
    }

    public IQueryable<UserEntity> GetAll(string userName)
    {
        var users = _dbContext.Users.Where(p => p.Name.Equals(userName)).AsQueryable();
        return users;
    }
}