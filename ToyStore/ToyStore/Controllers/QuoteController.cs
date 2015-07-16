using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToyStore.Controllers
{
    public class QuoteController : Controller
    {
        // GET: Quote
        [ChildActionOnly]
        public ActionResult GetQuote()
        {
            List<string> quotes = new List<string>
            {
                "We know what we are, but know not what we may be.",
                "It is not in the stars to hold our destiny but in ourselves.",
                "A fool thinks himself to be wise, but a wise man knows himself to be a fool.",
                "There is nothing either good or bad but thinking makes it so.",
                "No legacy is so rich as honesty."
            };

            Random rnd = new Random();
            var index = rnd.Next(5);

            return PartialView("_RandomQuote", quotes[index]);
        }
    }
}