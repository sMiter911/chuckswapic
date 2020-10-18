using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace chuckswapic.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SwapiController : ControllerBase
    {
        static string ChuckURL = "https://swapi.dev/api/people/";

        // GET: <ChuckController>
        /// <summary>
        /// Gets all the people related to the Star Wars Universe
        /// </summary>
        [HttpGet("people")]
        public string Get()
        {

            var client = new RestClient(ChuckURL);
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept", "application/json");
            IRestResponse response = client.Execute(request);

            return response.Content;
        }
    }
}
