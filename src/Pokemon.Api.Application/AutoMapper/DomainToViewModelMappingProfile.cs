using AutoMapper;
using Pokemon.Api.Application.ViewModel.Responses;
using Pokemon.Api.Domain.Models.ExternalResponse;

namespace Pokemon.Api.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ExternalPokemon, PokemonResponse>()
                .ForMember(des => des.Types, opt => opt.MapFrom(src => src.Types.Select(type => type.Type.Name)));
        }
    }
}