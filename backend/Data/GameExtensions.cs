using backend.DTOs;

namespace backend.Data;

public static class GameExtensions
{
    public static GetGameDTO ToDTO(this GameEntity gameEntity)
    {
        return new GetGameDTO()
        {
            Id = gameEntity.Id,
            Name = gameEntity.Name,
            Price = gameEntity.Price,
            ReleaseDate = gameEntity.ReleaseDate,
        };
    }

    public static GameEntity ToEntity(this CreateGameDTO createGameDTO)
    {
        return new GameEntity()
        {
            Name = createGameDTO.Name,
            Price = createGameDTO.Price,
            ReleaseDate = createGameDTO.ReleaseDate,
        };
    }
}