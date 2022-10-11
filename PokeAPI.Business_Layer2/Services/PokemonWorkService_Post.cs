using PokeAPI.DataAccess_Layer;
using PokeAPI.Entity_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.Business_Layer.Services
{
    public class PokemonWorkService_Post
    {
        public bool SetFavoritePokemon(int id)
        {
            return new PokemonModel().setFavoritePokemon(id).Result;
        }
    }
}
