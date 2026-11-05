using PruebaTecnica.Dominio;

namespace PruebaTecnica.Application.Clientes;

public class ClienteService (IClientesRepository repository, IUnitOfWork unitOfWork): IClienteService
{
    public async Task<Result<ClientesDtos.ClienteRes>> Add(ClientesDtos.CreateClienteReq clientes, CancellationToken ct)
    {
        var result = Dominio.Clientes.Create(clientes.nombre, clientes.apellido, clientes.cedula);
        if (result.IsFailure) return result.Error!;

        var cliente = result.Value;
        await repository.Add(cliente, ct);
        await unitOfWork.SaveChangesAsync(ct);
        return cliente.ToResponse();
    }
}