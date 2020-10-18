using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chuckswapic.Models
{
    
    public class ChuckNorrisModel
    {

        public string total { get; set; }
        public result[] result { get; set; }
    }

    public class result
    {
        public string[] categories { get; set; }
        public string created_at { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }
    }
}
