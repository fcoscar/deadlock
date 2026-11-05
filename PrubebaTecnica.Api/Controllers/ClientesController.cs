using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Application.Clientes;

namespace PrubebaTecnica.Api.Controllers;

[Microsoft.AspNetCore.Components.Route("api/clientes")]
public class ClientesController(IClienteService service): BaseApiController
{
    [HttpPost]
    public async Task<IActionResult> Create(ClientesDtos.CreateClienteReq request, CancellationToken ct)
    {
        var result = await service.Add(request, ct);
        return result.IsSuccess
            ? Ok(result.Value)
            : HandleFailure(result.Error!);
    }
}