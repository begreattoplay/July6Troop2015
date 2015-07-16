using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToyStore.Controllers
{
    public class ToyController : Controller
    {
        // GET: Toy
        public ActionResult Index()
        {
            return View();
        }
    }
}