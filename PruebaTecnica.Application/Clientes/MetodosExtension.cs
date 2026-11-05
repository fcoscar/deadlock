namespace PruebaTecnica.Application.Clientes;

internal static class ClienteMappings
{
    public static ClientesDtos.ClienteRes ToResponse(this Dominio.Clientes p) => new(p.Nombre, p.Apellidos, p.Cedula);
}
