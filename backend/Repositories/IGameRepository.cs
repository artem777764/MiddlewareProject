using backend.Data;

namespace backend.Repositories;

public interface IGameRepository
{
    Task CreateGameAsync(GameEntity gameEntity);
    Task<List<GameEntity>> GetAllGamesAsync();
    Task<GameEntity?> GetGameByIdAsync(int id);
}
