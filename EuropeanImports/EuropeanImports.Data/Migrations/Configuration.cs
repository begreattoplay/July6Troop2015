namespace EuropeanImports.Data.Migrations
{
    using EuropeanImports.Data.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EuropeanImports.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EuropeanImports.Data.ApplicationDbContext context)
        {
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            const string NICKEMAIL = "nick@codercamps.com";

            var nick = userManager.FindByName(NICKEMAIL);

            if (nick == null)
            {
                nick = new ApplicationUser
                {
                    UserName = NICKEMAIL,
                    Email = NICKEMAIL
                };

                userManager.Create(nick, "123456");
                nick = userManager.FindByName(NICKEMAIL);
            }

            var tom = userManager.FindByName("tom@codercamps.com");

            if (tom == null)
            {
                tom = new ApplicationUser
                {
                    UserName = "tom@codercamps.com",
                    Email = "tom@codercamps.com"
                };

                userManager.Create(tom, "123456");
                tom = userManager.FindByName("tom@codercamps.com");
            }


            Car[] cars = new Car[]
            {
                new Car { Make = "Ferrari", Model = "California", Color = "Red", IsBadass = true, Price = 200000m, UserId = nick.Id },
                new Car { Make = "Porche", Model = "911 Turbo S", Color = "Silver", IsBadass = true, Price = 190000m, UserId = tom.Id },
                new Car { Make = "Toyota", Model = "Prius", Color = "Green", IsBadass = false, Price = 35000m, UserId = tom.Id },
                new Car { Make = "Chevy", Model = "El Camino", Color = "Pink", IsBadass = true, Price = 7000m, UserId = nick.Id },
            };

            context.Cars.AddOrUpdate(c => c.Model, cars);

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
