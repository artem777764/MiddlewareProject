using System.Threading.Tasks;
using backend.DTOs;
using backend.Errors;
using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class GameController : ControllerBase
{
    private readonly IGameService _service;

    public GameController(IGameService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<List<GetGameDTO>> GetAllGamesAsync()
    {
        return await _service.GetAllGamesAsync();
    }

    [HttpGet("{id}")]
    public async Task<GetGameDTO?> GetGameByIdAsync([FromRoute] int id)
    {
        GetGameDTO? gameDTO = await _service.GetGameByIdAsync(id);
        if (gameDTO == null) return null;
        return gameDTO;
    }

    [HttpPost]
    public async Task CreateGameAsync(CreateGameDTO createGameDTO)
    {
        await _service.CreateGameAsync(createGameDTO);
    }
}