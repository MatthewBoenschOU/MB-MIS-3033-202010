using MVCBeginner.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVCBeginner.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            PokemonAPI Poke;

            using (var Client = new HttpClient())
            {
                var JSON = Client.GetStringAsync("https://pokeapi.co/api/v2/pokemon?limit=1100&offset=0/").Result;
                Poke = JsonConvert.DeserializeObject<PokemonAPI>(JSON);
            }
            return View(Poke.Results);
        }
        public ActionResult Details(string id)
        {
            Stats PokeInfo;
            string SelectedPoke = "https://pokeapi.co/api/v2/pokemon/" + $"{id}/";

            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync(SelectedPoke).Result;
                PokeInfo = JsonConvert.DeserializeObject<Stats>(json);
            }
            return View(PokeInfo);
        }
    }
}