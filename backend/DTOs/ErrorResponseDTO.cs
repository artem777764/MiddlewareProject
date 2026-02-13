namespace backend.DTOs;

public record ErrorResponseDTO
{
    public required string Code { get; set; }
    public required string Message { get; set; }
    public required string RequestId { get; set; }
}