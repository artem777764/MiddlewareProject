using backend.Data;
using backend.DTOs;
using backend.Errors;
using backend.Repositories;

namespace backend.Services;

public class GameService : IGameService
{
    private readonly IGameRepository _repository;

    public GameService(IGameRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetGameDTO>> GetAllGamesAsync()
    {
        List<GameEntity> gameEntities = await _repository.GetAllGamesAsync();
        return gameEntities.Select(g => g.ToDTO()).ToList();
    }

    public async Task<GetGameDTO> GetGameByIdAsync(int id)
    {
        GameEntity? gameEntity = await _repository.GetGameByIdAsync(id);
        if (gameEntity == null) throw new NotFoundException("Игра с данным Id не найдена");
        return gameEntity.ToDTO();
    }

    public async Task CreateGameAsync(CreateGameDTO createGameDTO)
    {
        if (createGameDTO.Name == "") throw new ValidationException("Некорректное название игры");
        if (createGameDTO.Price < 0) throw new ValidationException("Некорректная цена игры");
        await _repository.CreateGameAsync(createGameDTO.ToEntity());
    }

    private bool IsCreateGameDTOCorrect(CreateGameDTO createGameDTO)
    {
        if (createGameDTO.Name == "") throw new ValidationException("Некорректное название игры");
        if (createGameDTO.Price < 0) throw new ValidationException("Некорректная цена игры");
        return true;
    }
}