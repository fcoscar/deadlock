namespace PruebaTecnica.Dominio;

public interface IClientesRepository
{
    Task<Clientes> Add(Clientes cliente, CancellationToken ct);
}