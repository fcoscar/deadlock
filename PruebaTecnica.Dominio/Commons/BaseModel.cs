namespace PruebaTecnica.Dominio;

public class BaseModel
{
    public Guid Id { get; set; } = new Guid();
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
}