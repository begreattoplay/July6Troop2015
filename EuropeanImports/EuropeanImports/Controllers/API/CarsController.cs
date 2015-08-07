using EuropeanImports.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using EuropeanImports.Models;

namespace EuropeanImports.Controllers.API
{
    public class CarsController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        [Authorize]
        public IHttpActionResult Get()
        {
            var userId = User.Identity.GetUserId();

            IList<CarViewModel> cars = _db.Cars.Where(c => c.UserId == userId).Select(c => new CarViewModel
                {
                    Color = c.Color,
                    IsBadass = c.IsBadass,
                    Make = c.Make,
                    Model = c.Model,
                    Price = c.Price,
                    UserName = c.User.UserName
                }).ToList();

            return Ok(cars);
        }
    }
}
