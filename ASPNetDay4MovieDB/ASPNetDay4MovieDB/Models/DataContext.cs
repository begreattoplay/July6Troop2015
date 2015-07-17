using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNetDay4MovieDB.Models
{
    public class DataContext : DbContext
    {
        static DataContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public IDbSet<Movie> Movies { get; set; }
    }
}