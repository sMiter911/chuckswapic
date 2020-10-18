using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chuckswapic.Models
{
    public class ResultSet
    {
        public string chuckNorrisUrl { get; set; }
        public ChuckNorrisModel chuckNorris { get; set; }

        public string starWarsUrl { get; set; }
        public StarWarsModel starWars { get; set; }
    }
}
