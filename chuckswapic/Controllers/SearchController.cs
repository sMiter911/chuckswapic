﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chuckswapic.Models;
using chuckswapic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace chuckswapic.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        ISearchService _searchService;

        public SearchController(SearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet]
        public async Task<ResultSet> getResults([FromQuery] string query)
        {
            var chuckNorris = await _searchService.searchChuckAsync(query);
            var starWars = await _searchService.searchStarWarsAsync(query);

            var resultSet = new ResultSet();
            resultSet.chuckNorris = chuckNorris;
            resultSet.chuckNorrisUrl = "https://api.chucknorris.io/jokes/search?query=" + query;

            resultSet.starWars = starWars;
            resultSet.starWarsUrl = "https://swapi.dev/api/people/?search=" + query;
            return resultSet;
        }

    }
}
