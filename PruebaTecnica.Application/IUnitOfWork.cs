namespace PruebaTecnica.Application;

public interface IUnitOfWork
{
    Task<int> SaveChanges();
}