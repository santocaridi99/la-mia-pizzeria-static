using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
//using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //informazioni pizza
            //List<string> nome = new List<string>() { "margherita", "capricciosa", "salsiccia e patate", "marinara", "4 stagioni" };
            //List<string> descrizione = new List<string>() { "la classica pizza margherita", "la nostrà specialità", "la golosa", "grande classico", "la più venduta" };
            ////inserire le immagini
            //List<int> prezzo = new List<int>() { 3, 4, 5, 3, 4 };


            //ViewData["nome"] = nome;
            //ViewData["descrizione"] = descrizione;
            //ViewData["prezzo"] = prezzo;
            return View();
        }

        [HttpPost]
        public ActionResult Send(IList<String> input)
        {
            return View(input);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}