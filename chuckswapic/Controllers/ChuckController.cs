using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp.Authenticators;
using RestSharp;
using chuckswapic.Models;
using Newtonsoft.Json;
using RestSharp.Extensions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace chuckswapic.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class ChuckController : ControllerBase
    {
        static string ChuckURL = "https://api.chucknorris.io/jokes/categories";

        // GET: api/<ChuckController>
        [HttpGet("categories")]
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
