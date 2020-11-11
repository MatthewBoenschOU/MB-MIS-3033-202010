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
    public class ChuckController : Controller
    {
        // GET: Chuck
        public ActionResult Index()
        {
            ChuckAPI Joke;

            using (var Client = new HttpClient())
            {
                var JSON = Client.GetStringAsync("https://api.chucknorris.io/jokes/random").Result;
                Joke = JsonConvert.DeserializeObject<ChuckAPI>(JSON);

            }
            return View(Joke);
        }
    }
}