namespace PruebaTecnica.Dominio;

public class Productos : BaseModel
{
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
}