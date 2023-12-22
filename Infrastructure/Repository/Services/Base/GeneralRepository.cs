using Infrastructure.Repository.Interfaces.Base;

namespace Infrastructure.Repository.Services.Base;

public sealed class GeneralRepository(EFContext _context) : IGeneralRepository

{
    public async Task AddAsync<T>(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete<T>(T entity)
    {
        _context.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update<T>(T entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
    }
}
