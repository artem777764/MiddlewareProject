namespace backend.DTOs;

public record GetGameDTO
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required int Price { get; set; }
    public DateOnly? ReleaseDate { get; set; }
}