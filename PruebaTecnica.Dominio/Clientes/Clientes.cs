using PruebaTecnica.Application;

namespace PruebaTecnica.Dominio;

public class Clientes : BaseModel
{
    public string Nombre {get;set;}
    public string Apellidos { get; set; }
    public string Cedula { get; set; }

    private Clientes() {}

    public static Result<Clientes> Create(string nombre, string apellidos, string cedula)
    {
        if (string.IsNullOrWhiteSpace(nombre)) return ClienteErrors.NameRequired;
        if (string.IsNullOrWhiteSpace(apellidos)) return ClienteErrors.LastNameRequired;
        if (string.IsNullOrWhiteSpace(cedula)) return ClienteErrors.CedulaRequired;
        
        return new Clientes() {Nombre = nombre.Trim(), Apellidos = apellidos.Trim(), Cedula = cedula.Trim() };
    }
} 