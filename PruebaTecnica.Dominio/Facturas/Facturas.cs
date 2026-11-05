namespace PruebaTecnica.Dominio;

public class Facturas : BaseModel
{
    public Clientes Cliente { get; set; }
    public Ordenes Orden { get; set; }
    public decimal Total { get; set; }
}