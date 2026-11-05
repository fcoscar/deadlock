namespace PruebaTecnica.Application.Clientes;

public interface IClienteService
{
    Task<Dominio.Clientes> Add(Dominio.Clientes clientes, CancellationToken ct);
}