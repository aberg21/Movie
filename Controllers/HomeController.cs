using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DateMe.Models;
using Microsoft.EntityFrameworkCore;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        
        private MovieLibraryContext blahContext { get; set; }


        //controller
        public HomeController(MovieLibraryContext blahContext)
        {

            this.blahContext = blahContext;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Podcasts()
        {


            return View("Podcasts");
        }


        [HttpGet]
        public IActionResult FillOutApplication()
        {
            ViewBag.Categories = blahContext.categories.ToList(); 
                return View("MoviesApplication");
        }

        [HttpPost]
        public IActionResult FillOutApplication(ApplicationResponse ar)

        {
            if (ModelState.IsValid)
            {
                blahContext.Add(ar);
                blahContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = blahContext.categories.ToList();
                return View(ar);
            }
        }

        public IActionResult MoviesList()
        {
            var responses = blahContext.responses
                .Include(x => x.categories)
                .OrderBy(response => response.Title)
                .ToList();
            return View(responses);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {

            ViewBag.Categories = blahContext.categories.ToList();

            var response = blahContext.responses.Single(x => x.MovieId == movieid);

            return View("MoviesApplication", response);

        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse ar)
        {
            blahContext.Update(ar);
            blahContext.SaveChanges();

            return RedirectToAction("MoviesList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var responses = blahContext.responses.Single(x => x.MovieId == movieid);
            return View(responses);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            blahContext.responses.Remove(ar);
            blahContext.SaveChanges();

            return RedirectToAction("MoviesList");
        }

    }
}
