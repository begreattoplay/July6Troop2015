﻿using ASPNetDay4MovieDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetDay4MovieDB.Controllers
{
    public class MoviesController : Controller
    {
        private IGenericRepository _repo;

        public MoviesController(IGenericRepository repo)
        {
            _repo = repo;
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _repo
                .Query<Movie>()
                .Include(m => m.Genre)
                .OrderBy(m => m.Title)
                .ToList();

            return View(movies);
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
                _repo.Add<Movie>(movie);
                _repo.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Movie movie = _repo.Find<Movie>(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                var originalMovie = _repo.Find<Movie>(movie.Id);
                originalMovie.Title = movie.Title;
                originalMovie.Director = movie.Director;
                _repo.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Movie movie = _repo.Find<Movie>(id);
            return View(movie);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            _repo.Delete<Movie>(id);
            _repo.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}