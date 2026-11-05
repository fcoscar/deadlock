using PruebaTecnica.Dominio;

namespace PruebaTecnica.Application.Clientes;

public class ClienteRepository : IClientesRepository
{
    public Task<Dominio.Clientes> Add(Dominio.Clientes cliente, CancellationToken ct)
    {
        
    }
    
    
}