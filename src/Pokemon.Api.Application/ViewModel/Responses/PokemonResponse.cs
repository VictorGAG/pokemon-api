using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Api.Application.ViewModel.Responses
{
    public class PokemonResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public IEnumerable<string> Types { get; set; } = Enumerable.Empty<string>();
    }
}