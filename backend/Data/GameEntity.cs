namespace backend.Data;

public class GameEntity
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int Price { get; set; }
    public DateOnly? ReleaseDate { get; set; }
}