namespace Infrastructure.Repository.Interfaces.Base;

public interface IGeneralRepository
{
    Task AddAsync<T>(T entity);
    Task Delete<T>(T entity);
    Task Update<T>(T entity);
}
