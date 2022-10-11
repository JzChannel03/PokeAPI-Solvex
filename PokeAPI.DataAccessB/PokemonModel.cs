using Microsoft.EntityFrameworkCore;
using PokeAPI.Entity_Layer.Context;
using PokeAPI.Entity_Layer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public async Task<bool> setFavoritePokemon(int id)
        {
            try
            {
                var item = await context.FavoritePokemons.SingleOrDefaultAsync(i => i.IDPokemon == id);
                if (item == null)
                {
                    await context.Set<FavoritePokemon>().AddAsync(new FavoritePokemon() { IDPokemon = id });
                    await context.SaveChangesAsync();
                    return true;
                }
                return false;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool deleteFavoritePokemon(int id)
        {
            try
            {
                var itemToRemove = context.FavoritePokemons.SingleOrDefault(x => x.IDPokemon == id);
                if (itemToRemove != null)
                {
                    context.FavoritePokemons.Remove(itemToRemove!);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
        }
    }
}
