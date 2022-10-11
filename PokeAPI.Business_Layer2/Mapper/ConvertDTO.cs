using PokeAPI.Entity_Layer.Models;
using PokeAPI_Solvex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.Business_Layer.Mapper
{
    public class ConvertDTO
    {
        public static PokemonData ToPokemonDataType(PokemonDTO? pokemonDTO)
        {
            PokemonData pokemon = new PokemonData();
            pokemon.ID = pokemonDTO!.id;
            pokemon.Name = pokemonDTO.name;
            pokemon.Img = pokemonDTO.sprites!.front_default;
            pokemon.Height = pokemonDTO.height;
            pokemon.Weight = pokemonDTO.weight;
            pokemon.Abilities = pokemonDTO.abilities!.Take(2).Select(i => i.ability!.name).ToList();
            pokemon.Moves = pokemonDTO.moves!.Take(3).Select(i => i.move!.name).ToList();
            return pokemon;
        }
    }
}
