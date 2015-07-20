namespace ASPNetDay4MovieDB.Migrations
{
    using ASPNetDay4MovieDB.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASPNetDay4MovieDB.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ASPNetDay4MovieDB.Models.DataContext";
        }

        protected override void Seed(ASPNetDay4MovieDB.Models.DataContext context)
        {
            var movies = new Movie[]
            {
                new Movie { Title = "Star Wars", Director = "Lucas" },
                new Movie { Title = "Momento", Director = "Nolan" },
                new Movie { Title = "King Kong", Director = "Jackson" }
            };

            context.Movies.AddOrUpdate(m => m.Title, movies);


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
