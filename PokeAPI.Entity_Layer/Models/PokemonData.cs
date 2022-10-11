using PokeAPI_Solvex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.Entity_Layer.Models
{
    public class PokemonData
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Img { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<string?>? Abilities { get; set; }
        public List<string?>? Moves { get; set; }

    }
}
