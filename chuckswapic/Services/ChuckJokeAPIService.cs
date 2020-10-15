using chuckswapic.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace chuckswapic.Services
{ 
    //public interface IChuckJokeService
    //{
    //    ChuckJokeCategories GetCategoriesAsync();
    //}




    //public class ChuckJokeAPIService : IChuckJokeService
    //{
    //    static string ChuckURL = "https://api.chucknorris.io/jokes/categories";

    //    public async Task<ChuckJokeCategories> GetCategoriesAsync()
    //    {
    //        var client = new HttpClient();
    //        var request = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri(ChuckURL),
    //            Headers =
    //            {
    //                { "accept", "application/json" }
    //            },
    //        };
    //        using (var response = await client.SendAsync(request))
    //        {
    //            response.EnsureSuccessStatusCode();
    //            var bodyResponse = await response.Content.ReadAsStringAsync();
    //            Console.WriteLine(bodyResponse);
    //        }
    //    }
    //}
}
