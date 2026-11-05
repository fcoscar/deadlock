namespace PruebaTecnica.Application.Clientes;

public interface IClienteService
{
    Task<Result<ClientesDtos.ClienteRes>> Add(ClientesDtos.CreateClienteReq clientes, CancellationToken ct);
}