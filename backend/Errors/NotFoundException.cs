namespace backend.Errors;

public sealed class NotFoundException : DomainException
{
    public NotFoundException(string message)
        : base(code: "NOT_FOUND", message: message, statusCode: 404)
    {
    }
}