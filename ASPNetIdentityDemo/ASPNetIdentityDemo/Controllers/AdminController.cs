using ASPNetIdentityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetIdentityDemo.Controllers
{
    [Authorize(Roles=Role.ADMINISTRATOR)]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return Content("You're an Admin congrats!!");
        }
    }
}