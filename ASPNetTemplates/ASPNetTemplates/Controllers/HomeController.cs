using ASPNetTemplates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetTemplates.Controllers
{
    public class HomeController : Controller
    {
        private IList<Product> _products;

        public HomeController()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Peanut Butter", Price = 3.99m, Weight = 12.54m },
                new Product { Id = 2, Name = "Jelly", Price = 4.72m, Weight = 6.23m }
            };
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            Product prod = _products.FirstOrDefault(p => p.Id == id);
            return View(prod);
        }
    }
}