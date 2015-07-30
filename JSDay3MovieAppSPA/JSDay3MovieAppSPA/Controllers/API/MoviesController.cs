using JSDay3MovieAppSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JSDay3MovieAppSPA.Controllers.API
{
    public class MoviesController : ApiController
    {
        private MoviesDbContext _db;

        public MoviesController()
        {
            _db = new MoviesDbContext();
        }

        public IHttpActionResult Get()
        {
            var movies = _db.Movies.ToList();

            return Ok(movies);
        }

        public IHttpActionResult Post(Movie movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();

            return Ok(new { success = true });
        }
    }
}
