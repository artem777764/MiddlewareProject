using backend.DTOs;

namespace backend.Services;

public interface IGameService
{
    Task CreateGameAsync(CreateGameDTO createGameDTO);
    Task<List<GetGameDTO>> GetAllGamesAsync();
    Task<GetGameDTO> GetGameByIdAsync(int id);
}
