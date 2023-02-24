using ctyoung1_mission6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        private Context _blahContext { get; set; }
        public HomeController(ILogger<HomeController> logger, Context x)
        {

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
        public IActionResult MovieDatabase()
        {
            var applications = _blahContext.Responses.Include(x => x.Category).ToList();
            return View(applications);
        }
        [HttpGet]
        public IActionResult Movies()
        {

            ViewBag.Categorys = _blahContext.Categorys.ToList();
            return View("Movies", new ApplicationResponse());
        }
        [HttpPost]
        public IActionResult Movies(ApplicationResponse ar)
        {
            _blahContext.Add(ar);
            _blahContext.SaveChanges();
            return View("Conformation", ar);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {

            ViewBag.Categorys = _blahContext.Categorys.ToList();

            var application = _blahContext.Responses.Single(x => x.movieId == id);
            return View("Movies", application);
        }
        [HttpPost]
        public IActionResult Edit(ApplicationResponse movie)
        {

            if (ModelState.IsValid)
            {
                _blahContext.Update(movie);
                _blahContext.SaveChanges();
                return RedirectToAction("MovieDatabase");
            }
            else
            {
                return View("Movies");
            }

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var application = _blahContext.Responses.Single(x => x.movieId == id);


            return View(application);
        }
        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            _blahContext.Responses.Remove(ar);
            _blahContext.SaveChanges();
            return RedirectToAction("MovieDatabase");
        }
    }
}
