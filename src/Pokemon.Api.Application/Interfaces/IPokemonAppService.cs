using Pokemon.Api.Application.ViewModel.Responses;

namespace Pokemon.Api.Application.Interfaces
{
    public interface IPokemonAppService
    {
        Task<PokemonServiceResponse<PokemonResponse>> GetPokemonById(int id);
    }
}