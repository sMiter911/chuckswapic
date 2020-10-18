using chuckswapic.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace chuckswapic.Services
{
    public interface ISearchService
    {
        Task<ChuckNorrisModel> searchChuckAsync(string query);
        Task<StarWarsModel> searchStarWarsAsync(string query);

    }
    public class SearchService : ISearchService
    {

        public async Task<ChuckNorrisModel> searchChuckAsync(string query)
        {
            string url = "https://api.chucknorris.io/jokes/search?query=" + query;

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
                var a = JsonConvert.DeserializeObject<ChuckNorrisModel>(body);
                
                ResultSet result = new ResultSet();

                return a;
            }
        }

        public async Task<StarWarsModel> searchStarWarsAsync(string query)
        {
            string url = "https://swapi.dev/api/people/?search=" + query;

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

                ResultSet result = new ResultSet();

                return a;
            }
        }
    }
}
