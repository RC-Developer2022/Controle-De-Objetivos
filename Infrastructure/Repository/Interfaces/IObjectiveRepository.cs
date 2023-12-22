using Domain.Entities;

namespace Infrastructure.Repository.Interfaces;

public interface IObjectiveRepository
{
    Task<IEnumerable<Objective>> GetObjectivesAsync();
    Task<IEnumerable<Objective>> GetObjectivesByNameAsync(string name);
    Task<>
}
