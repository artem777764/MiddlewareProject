using backend.Data;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories;

public class GameRepository : IGameRepository
{
    private readonly ApplicationContext _context;

    public GameRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<List<GameEntity>> GetAllGamesAsync()
    {
        return await _context.Games.AsNoTracking().ToListAsync();
    }

    public async Task<GameEntity?> GetGameByIdAsync(int id)
    {
        return await _context.Games.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
    }

    public async Task CreateGameAsync(GameEntity gameEntity)
    {
        await _context.Games.AddAsync(gameEntity);
        await _context.SaveChangesAsync();
    }
}