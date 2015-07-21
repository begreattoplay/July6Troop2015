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
            var genres = new Genre[]
            {
                new Genre { Name = "SciFi" },
                new Genre { Name = "Action" },
                new Genre { Name = "Mystery" },
                new Genre { Name = "Drama" },
                new Genre { Name = "Comedy" }
            };

            context.Genres.AddOrUpdate(g => g.Name, genres);
            context.SaveChanges();

            var movies = new Movie[]
            {
                new Movie { Title = "Star Wars", Director = "Lucas", GenreId = genres[0].Id },
                new Movie { Title = "Momento", Director = "Nolan", GenreId = genres[3].Id },
                new Movie { Title = "King Kong", Director = "Jackson", GenreId = genres[1].Id }
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
