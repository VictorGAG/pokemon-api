using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Api.Domain.Models.ExternalResponse
{
    public class ExternalPokemonTypes
    {
        public int Slot { get; set; }
        public ExternalPokemonType Type { get; set; } = new ExternalPokemonType();
    }
}