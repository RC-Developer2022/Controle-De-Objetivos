using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class EFContext : DbContext
{
    public EFContext(DbContextOptions<EFContext> options) : base(options){}

    DbSet<Objective> Objetivos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EFContext).Assembly);
    }
}
