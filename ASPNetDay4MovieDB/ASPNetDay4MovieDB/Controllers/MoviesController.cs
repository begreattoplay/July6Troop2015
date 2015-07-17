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
    }
}