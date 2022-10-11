using PokeAPI.Business_Layer.Mapper;
using PokeAPI.DataAccess_Layer;
using PokeAPI.DataAccess_Layer.APIRepository;
using PokeAPI.Entity_Layer.Entities;
using PokeAPI.Entity_Layer.Models;
using PokeAPI_Solvex.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business_Layer.Services
{
    public class PokemonWorkService_Get
    {
        private PokeAPIResources pokeAPIResources = new PokeAPIResources();
        public async Task<List<PokemonData>> GetFavoritePokemons()
        {
            var PokemonDbList = await new PokemonModel()
                .readFavoritePokemons();

            List<PokemonData> pokemonDatas = new List<PokemonData>();

            foreach (var item in PokemonDbList)
            {
                pokemonDatas.Add(ConvertDTO.ToPokemonDataType(await pokeAPIResources.GetPokemon(item.IDPokemon)));
            }

            return pokemonDatas;
        }

        public async Task<PokemonData> GetPokemon(int id)
        {
            var PokemonList = await pokeAPIResources.GetPokemon(id);
            return ConvertDTO.ToPokemonDataType(PokemonList);
        }

        public async Task<List<PokemonData>> GetPokemonList(int first, int last)
        {
            List<PokemonData> pokemonDatas = new List<PokemonData>();
            for (int i = first; i <= last; i++)
            {
                pokemonDatas.Add(await GetPokemon(i));
            }
            return pokemonDatas;
        }

        

    }
}
