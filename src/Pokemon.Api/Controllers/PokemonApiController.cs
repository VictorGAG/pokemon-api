using Microsoft.AspNetCore.Mvc;
using Pokemon.Api.Application.Interfaces;
using Pokemon.Api.Application.ViewModel.Responses;

namespace Pokemon.Api.Controllers;

[ApiController]
[Route("v1/pokemon")]
public class PokemonApiController : ControllerBase
{
    private readonly ILogger<PokemonApiController> _logger;
    private readonly IPokemonAppService _pokemonAppService;

    public PokemonApiController(ILogger<PokemonApiController> logger, IPokemonAppService pokemonAppService)
    {
        _logger = logger;
        _pokemonAppService = pokemonAppService;
    }

    [HttpPost("{id}")]
    public async Task<ActionResult<PokemonServiceResponse<PokemonResponse>>> FindPokemonById(int id)
    {
        _logger.LogInformation($"FindingPokemon with id: {id}");

        return Ok(await _pokemonAppService.GetPokemonById(id));
    }
}
