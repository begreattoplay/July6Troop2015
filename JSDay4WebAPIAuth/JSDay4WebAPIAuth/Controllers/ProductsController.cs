using JSDay4WebAPIAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSDay4WebAPIAuth.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Apples" },
                new Product { Id = 2, Name = "Apricots" },
                new Product { Id = 3, Name = "Antelopes" },
                new Product { Id = 4, Name = "Salt" },
                new Product { Id = 5, Name = "Sugar" },
                new Product { Id = 6, Name = "Sand" },
                new Product { Id = 7, Name = "Sardines" }
            };

            return View(products);
        }

        public ActionResult SaveOrder(int[] order)
        {
            // save order to db
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ShoppingCart()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Apples" },
                new Product { Id = 2, Name = "Apricots" },
                new Product { Id = 3, Name = "Antelopes" },
                new Product { Id = 4, Name = "Salt" },
                new Product { Id = 5, Name = "Sugar" },
                new Product { Id = 6, Name = "Sand" },
                new Product { Id = 7, Name = "Sardines" }
            };

            return View(products);
        }

        public ActionResult SaveCart()
        {
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Find(string term)
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Apples" },
                new Product { Id = 2, Name = "Apricots" },
                new Product { Id = 3, Name = "Antelopes" },
                new Product { Id = 4, Name = "Salt" },
                new Product { Id = 5, Name = "Sugar" },
                new Product { Id = 6, Name = "Sand" },
                new Product { Id = 7, Name = "Sardines" }
            };

            var matches = products
                .Where(p => p.Name.StartsWith(term, StringComparison.InvariantCultureIgnoreCase))
                .OrderBy(p => p.Name)
                .Select(p => p.Name)
                .ToList();

            return Json(matches, JsonRequestBehavior.AllowGet);
        }
    }
}