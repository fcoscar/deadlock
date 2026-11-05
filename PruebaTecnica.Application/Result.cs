using PruebaTecnica.Dominio;

namespace PruebaTecnica.Application;

public class Result
{
    public bool IsSucces { get; }
    public bool IsFailure => !IsSucces;
    public Error Error { get; }
    
    protected Result(bool isSuccess, Error error)
    {
        IsSucces = isSuccess;
        Error = error;
    }

    public static Result Success() => new(true, null);
    public static Result Failure(Error error) => new(false, error);
}