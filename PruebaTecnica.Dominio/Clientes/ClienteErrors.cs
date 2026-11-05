namespace PruebaTecnica.Dominio;

public static class ClienteErrors
{
    public static readonly Error NameRequired =
        Error.Validation("Nombres.NameRequired", "Los nombres son obligatorios.");
    public static readonly Error LastNameRequired =
        Error.Validation("Apellidos.LastNameRequired", "Los apellidos son obligatorios.");
    public static readonly Error CedulaRequired =
        Error.Validation("Cedeula.CedulaRequired", "La cedula es obligatoria.");
    public static Error NotFound(Guid id) =>
        Error.NotFound("Cliente.NotFound", $"Cliente {id} no encontrado.");
}