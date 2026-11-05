using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PruebaTecnica.Application;
using PruebaTecnica.Application.Clientes;
using PruebaTecnica.Dominio;
using PruebaTecnica.Infrastructure.Persistance;

namespace PruebaTecnica.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<Context>(o => o.UseSqlite(connectionString));
        services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<Context>());
        services.AddScoped<IClientesRepository, ClienteRepository>();
        return services;
    }
}