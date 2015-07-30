using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JSDay3MovieAppSPA.Models
{
    public class MoviesDbContext : DbContext
    {
        public IDbSet<Movie> Movies { get; set; }
    }
}