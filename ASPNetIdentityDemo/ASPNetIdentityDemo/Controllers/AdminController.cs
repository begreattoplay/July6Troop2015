using ASPNetIdentityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Security.Claims;

namespace ASPNetIdentityDemo.Controllers
{
    [Authorize(Roles=Role.ADMINISTRATOR)]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index(int clubId)
        {

            if (User.IsInRole(Role.ADMINISTRATOR))
            {
                //Do some stuff
            }

            //Get the currently logged in user's username
            string userName = User.Identity.Name;
            string userId = User.Identity.GetUserId();
            bool canEditProducts = (User.Identity as ClaimsIdentity).HasClaim("CanEditProducts", "true");
            
            return Content("You're an Admin congrats!!");
        }
    }
}