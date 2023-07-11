using AutoMapper;
using Pokemon.Api.Application.Interfaces;
using Pokemon.Api.Application.ViewModel.Responses;
using Pokemon.Api.Domain.Interfaces;

namespace Pokemon.Api.Application.Services
{
    public class PokemonAppService : IPokemonAppService
    {
        private readonly IMapper _mapper;
        private readonly IPokemonExternalService _externalService;

        public PokemonAppService(IMapper mapper, IPokemonExternalService externalService)
        {
            _mapper = mapper;
            _externalService = externalService;
        }

        public async Task<PokemonServiceResponse<PokemonResponse>> GetPokemonById(int id)
        {
            var response = new PokemonServiceResponse<PokemonResponse>();
            var pokemon = await _externalService.GetPokemon(id);
            
            response.Data = _mapper.Map<PokemonResponse>(pokemon);

            return response;
        }
    }
}