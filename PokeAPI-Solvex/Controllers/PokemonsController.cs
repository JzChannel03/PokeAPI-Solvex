
using Business_Layer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeAPI.Business_Layer.Services;
using PokeAPI.Entity_Layer.Entities;
using PokeAPI.Entity_Layer.Models;
using System.Collections;

namespace PokeAPI_Solvex.Controllers
{
    [ApiController]
    [Route("api/pokemons")]
    public class PokemonsController : ControllerBase
    {
        private readonly ILogger<PokemonsController> _logger;

        public PokemonsController(ILogger<PokemonsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("favorite")]
        public ActionResult<IEnumerable<PokemonData>> GetFavorites()
        {
            return new PokemonWorkService_Get().GetFavoritePokemons().Result.ToArray();
        }

        [HttpGet("listpokemon")]
        public ActionResult<IEnumerable<PokemonData>> GetListPokemon(int first, int last)
        {
            if (first <= 0) return NotFound();
            return new PokemonWorkService_Get().GetPokemonList(first, last).Result.ToArray();
        }

        [HttpPost("favorite/{id:int}")]
        public ActionResult PostFavorites(int id)
        {
            
            if ((id <= 0))
                return BadRequest();
            if (!(new PokemonWorkService_Post().SetFavoritePokemon(id)))
                return BadRequest(new { message = "This pokemon is already a favorite" });

            return Ok();

        }

        [HttpDelete("favorite/{id:int}")]
        public ActionResult DeleteFavorites(int id)
        {
            if (
                new PokemonWorkService_Delete().DeleteFavoritePokemon(id) == true
            ) return Ok();

            else return NotFound();
        }
    }
}
