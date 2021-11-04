using AronGibsonOMDBApiLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AronGibsonOMDBApiLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieDAL movieDAL = new MovieDAL();

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

        public IActionResult MovieNightSearch()
        {
            return View();
        }

        public IActionResult MovieNightResult(string t1,string t2,string t3)
        {
            MovieModel m1 = movieDAL.GetMovie(t1);
            MovieModel m2 = movieDAL.GetMovie(t2);
            MovieModel m3 = movieDAL.GetMovie(t3);
            List<MovieModel> MovieList = new List<MovieModel> {m1,m2,m3 };
            return View(MovieList);
        }


        public IActionResult MovieSearch()
        {
            return View();
        }

        public IActionResult MovieResult(string t)
        {
            MovieModel MM = movieDAL.GetMovie(t);
            return View(MM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
