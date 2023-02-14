using ctyoung1_mission6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ctyoung1_mission6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Context _blahContext { get; set; } 
        public HomeController(ILogger<HomeController> logger,Context x)
        {
            _logger = logger;
            _blahContext = x; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Movies(ApplicationResponse ar)
        {
            _blahContext.Add(ar);
            _blahContext.SaveChanges();
            return View("Conformation", ar);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
