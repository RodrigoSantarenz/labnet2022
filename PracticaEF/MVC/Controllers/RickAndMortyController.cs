using MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using PracticaBF.Entities;

namespace MVC.Controllers
{
    public class RickAndMortyController : Controller
    {

        public async Task<ActionResult> Index()
        {
            var cliente = new HttpClient();
            var json = await cliente.GetStringAsync("https://rickandmortyapi.com/api/character/[1,2,3,4,5,6,7,8,9,10]");
            List<RickAndMortyView> rickMorty = JsonConvert.DeserializeObject<List<RickAndMortyView>>(json);

            return View(rickMorty);
        }
    }
}