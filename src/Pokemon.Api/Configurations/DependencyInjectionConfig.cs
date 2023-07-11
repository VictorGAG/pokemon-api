using Pokemon.Api.Application.Interfaces;
using Pokemon.Api.Application.Services;
using Pokemon.Api.Domain.Interfaces;
using Pokemon.Api.Infra.ExternalService;

namespace Pokemon.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddScoped<IPokemonExternalService, PokemonExternalService>();
            services.AddScoped<IPokemonAppService, PokemonAppService>();
        }
    }
}