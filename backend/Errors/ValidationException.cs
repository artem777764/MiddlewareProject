namespace backend.Errors;

public sealed class ValidationException : DomainException
{
    public ValidationException(string message)
        : base(code: "VALIDATION", message: message, statusCode: 400)
    {
    }
}