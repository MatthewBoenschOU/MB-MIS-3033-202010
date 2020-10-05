using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorris
{
    class JokeAPI
    {
        [JsonProperty("value")]
        public List<Jokes> Cateogires { get; set; }
    }
    public class Jokes
    {
        public string url { get; set; }
        public string value { get; set; }
    }
}
