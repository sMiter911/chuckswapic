using chuckswapic.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace chuckswapic.Services
{
    public interface IChuckSwapiService
    {
        Task<StarWarsModel> getStarWarsAsync();
    }

    public class ChuckSwapiService : IChuckSwapiService
    {
        public async Task<StarWarsModel> getStarWarsAsync()
        {
            string url = "https://swapi.dev/api/people/";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers =
            {
                { "accept", "application/json" },
            },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                var a = JsonConvert.DeserializeObject<StarWarsModel>(body);

                return a;
            }
        }
    }
}
