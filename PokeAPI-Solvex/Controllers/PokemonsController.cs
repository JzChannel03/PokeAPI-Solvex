
using Business_Layer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeAPI.Entity_Layer.Entities;

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

        [HttpGet("favorites")]
        public IEnumerable<FavoritePokemon> Get()
        {
            //return new PokemonFavoriteModel().readClients();
            return new PokemonWorkService().readFavoritePokemons().Result.ToArray();
        }
    }
}
