using System.Text.Json;
using Pokemon.Api.Domain.Interfaces;
using Pokemon.Api.Domain.Models.ExternalResponse;

namespace Pokemon.Api.Infra.ExternalService
{
    public class PokemonExternalService : IPokemonExternalService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PokemonExternalService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }  

        public async Task<ExternalPokemon> GetPokemon(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var httpResponse = await GetPokemonResponse(client, id);

            httpResponse.EnsureSuccessStatusCode();

            using var responseStream = await httpResponse.Content.ReadAsStreamAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true};
            var responseObj = await JsonSerializer.DeserializeAsync<ExternalPokemon>(responseStream, options);

            if (responseObj is null)
            {
                throw new Exception("Error getting Pokemon");
            }

            return responseObj;
        }

        private async Task<HttpResponseMessage> GetPokemonResponse(HttpClient client, int id)
        {
            var httpRequest = GetHttpRequestMessage(id);
            var httpResponse = await client.SendAsync(httpRequest);

            return httpResponse;
        }

        private HttpRequestMessage GetHttpRequestMessage(int id)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, $"https://pokeapi.co/api/v2/pokemon/{id}");
            return httpRequest;
        }
  }
}