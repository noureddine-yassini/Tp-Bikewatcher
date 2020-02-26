using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;


namespace MvcMovie.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Acceuil()
        {
            return View();
        }

        public async Task<IActionResult> CarteAsync()
        {
            var Station = await Service.Station();
            var cardsBdx = await Service.StationBdx();

            var ResultBdx = new List<Station>();
            foreach (var stationBdx in cardsBdx)
            {
                var construit = new Station(stationBdx);
                ResultBdx.Add(construit);
            }

            Station.AddRange(ResultBdx);
            return View(Station);
        }
        public IActionResult MesFavoris()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> ListeDesStationsAsync()
        {
            var Station = await Service.Station();
            return View(Station);
        }
    }
}
