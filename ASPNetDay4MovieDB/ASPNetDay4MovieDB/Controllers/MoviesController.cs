using ASPNetDay4MovieDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetDay4MovieDB.Controllers
{
    public class MoviesController : Controller
    {
        private DataContext _db = new DataContext();

        // GET: Movies
        public ActionResult Index()
        {
            var movies = from m in _db.Movies select m;

            return View(movies.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Add(movie);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Movie movie = _db.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                Movie original = _db.Movies.Find(movie.Id);
                original.Title = movie.Title;
                original.Director = movie.Director;

                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Movie movie = _db.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            Movie original = _db.Movies.Find(id);
            _db.Movies.Remove(original);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}