using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chuckswapic.Models;
using chuckswapic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace chuckswapic.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SwapiController : ControllerBase
    {
        IChuckSwapiService _chuckSwapiService;

        public SwapiController(ChuckSwapiService chuckSwapiService)
        {
            _chuckSwapiService = chuckSwapiService;
        }

        // GET: <ChuckController>
        /// <summary>
        /// Gets all the people related to the Star Wars Universe
        /// </summary>
        [HttpGet("people")]
        public async Task<StarWarsModel> GetResults()
        {
            var starWarsPeople = await _chuckSwapiService.getStarWarsAsync();

            var result = starWarsPeople;

            return result;
        }
    }
}
