using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories;

public interface IRepository<T>
{
    Guid Create(T entity);
    void Update(T entity);
    T Read(Guid id);
    void Delete(Guid id);
    IQueryable<UserEntity> GetAll(string userName);
}