using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Application;
using PruebaTecnica.Dominio;

namespace PruebaTecnica.Infrastructure.Persistance;

public sealed class Context(DbContextOptions<Context> options) : DbContext(options), IUnitOfWork
{
    public DbSet<Clientes> Clientes => Set<Clientes>();

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
    
}