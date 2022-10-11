using PokeAPI.DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.Business_Layer.Services
{
    public class PokemonWorkService_Delete
    {
        public bool DeleteFavoritePokemon(int id)
        {
            return new PokemonModel().deleteFavoritePokemon(id);
        }
    }
}
