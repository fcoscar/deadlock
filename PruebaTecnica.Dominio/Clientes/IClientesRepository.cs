namespace PruebaTecnica.Dominio;

public interface IClientesRepository
{
    Task Add(Clientes cliente, CancellationToken ct);
}