namespace PruebaTecnica.Application.Clientes;

public class ClientesDtos
{
    public record CreateClienteReq(string nombre, string apellido, string cedula);
    public record ClienteRes(string nombre, string apellido, string cedula);
}