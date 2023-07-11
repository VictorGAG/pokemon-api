namespace Pokemon.Api.Domain.Models.ExternalResponse
{
    public class ExternalPokemon
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public IEnumerable<ExternalPokemonTypes> Types { get; set; } = Enumerable.Empty<ExternalPokemonTypes>();
    }
}