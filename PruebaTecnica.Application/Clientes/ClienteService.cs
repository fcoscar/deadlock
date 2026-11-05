using PruebaTecnica.Dominio;

namespace PruebaTecnica.Application.Clientes;

public class ClienteService (IClientesRepository repository, IUnitOfWork unitOfWork): IClienteService
{
    public Task<Dominio.Clientes> Add(Dominio.Clientes clientes, CancellationToken ct)
    {
        
    }
}