using Pokemon.Api.Domain.Models.ExternalResponse;

namespace Pokemon.Api.Domain.Interfaces
{
    public interface IPokemonExternalService
    {
        Task<ExternalPokemon> GetPokemon(int id);
    }
}