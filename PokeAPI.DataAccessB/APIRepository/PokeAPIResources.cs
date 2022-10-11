using PokeAPI_Solvex.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.DataAccess_Layer.APIRepository
{
    public class PokeAPIResources
    {
        public async Task<PokemonDTO?> GetPokemon(int id)
        {
            var client = new RestClient("https://pokeapi.co/");
            var request = new RestRequest($"api/v2/pokemon/{id}", Method.Get);
            RestResponse<PokemonDTO> response = await client.ExecuteAsync<PokemonDTO>(request);
            return response.Data;
        }

    }
}
