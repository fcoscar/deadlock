namespace PruebaTecnica.Dominio;

public class Ordenes : BaseModel
{
    public Clientes cliente { get; set; }
    public List<Productos> ProductosList { get; set; }
    
}