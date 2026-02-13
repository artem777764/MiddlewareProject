namespace backend.DTOs;

public record CreateGameDTO
{
    public required string Name { get; set; }
    public required int Price { get; set; }
    public DateOnly? ReleaseDate { get; set; }
}