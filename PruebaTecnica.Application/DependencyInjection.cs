using Microsoft.Extensions.DependencyInjection;
using PruebaTecnica.Application.Clientes;

namespace PruebaTecnica.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IClienteService, ClienteService>();
        return services;
    }
}