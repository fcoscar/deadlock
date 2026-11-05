namespace PruebaTecnica.Dominio;

public enum ErrorTypes {Validation, NotFound, Conflict}

public sealed record Error (string code, string message, ErrorTypes type)
{
    public static Error Validation(string code, string message) => new(code, message, ErrorTypes.Validation);
    public static Error NotFound(string code, string message) => new(code, message, ErrorTypes.NotFound);
    public static Error Conflict(string code, string message) => new(code, message, ErrorTypes.Conflict);
    
}