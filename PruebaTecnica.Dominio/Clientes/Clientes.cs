namespace PruebaTecnica.Dominio;

public class Clientes : BaseModel
{
    public string Nombre {get;set;}
    public string Apellidos { get; set; }
    public string Cedula { get; set; }

    private Clientes() {}

    public Clientes(string nombre, string apellidos, string cedula)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        Cedula = cedula;
    }

} 