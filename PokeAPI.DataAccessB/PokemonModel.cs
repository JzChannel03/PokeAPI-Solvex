using Microsoft.EntityFrameworkCore;
using PokeAPI.Entity_Layer.Context;
using PokeAPI.Entity_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.DataAccess_Layer
{
    public class PokemonModel
    {
        private PokeAPIDBContext context = new PokeAPIDBContext();

        public async Task<List<FavoritePokemon>> readFavoritePokemons()
        {
            
            return await context.FavoritePokemons.ToListAsync();
        }
    }
}
