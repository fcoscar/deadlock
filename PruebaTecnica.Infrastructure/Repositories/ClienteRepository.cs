using PruebaTecnica.Dominio;
using PruebaTecnica.Infrastructure.Persistance;

namespace PruebaTecnica.Application.Clientes;

public class ClienteRepository(Context db) : IClientesRepository
{
    public async Task Add(Dominio.Clientes cliente, CancellationToken ct)
    {
        await db.Clientes.AddAsync(cliente, ct);
    }
    
    
}