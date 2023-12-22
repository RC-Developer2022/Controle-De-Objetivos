namespace Infrastructure.Repository.Interfaces.Base;

public interface IUnitOfWork : IDisposable
{
    void BeginTransaction();
    void Commit();
    void Rollback();
}
