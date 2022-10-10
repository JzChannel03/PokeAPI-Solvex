using PokeAPI.DataAccess_Layer;
using PokeAPI.Entity_Layer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business_Layer.Services
{
    public class PokemonWorkService
    {
        public async Task<List<FavoritePokemon>> readFavoritePokemons()
        {

            return await new PokemonModel().readFavoritePokemons();
        }
    }
}
