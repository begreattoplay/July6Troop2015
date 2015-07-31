namespace JSDay4WebAPIAuth.Migrations
{
    using JSDay4WebAPIAuth.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JSDay4WebAPIAuth.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JSDay4WebAPIAuth.Models.ApplicationDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            var nick = userManager.FindByName("nick@codercamps.com");

            if (nick == null)
            {
                nick = new ApplicationUser
                {
                    UserName = "nick@codercamps.com",
                    Email = "nick@codercamps.com"
                };

                userManager.Create(nick, "123456");
            }
        }
    }
}
