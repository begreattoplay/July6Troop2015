using JSDay3MVCWithJSON.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JSDay3MVCWithJSON.Controllers.api
{
    public class ProductsController : ApiController
    {
        private static ConcurrentStack<Product> _products;

        static ProductsController()
        {
            _products = new ConcurrentStack<Product>(new List<Product>
            {
                new Product { Name = "Milk", Price = 2.33m },
                new Product { Name = "Cheese", Price = 55.33m },
                new Product { Name = "Tesla", Price = 8989.33m }
            });
        }

        public IHttpActionResult Get()
        {
            var products = _products;

            return Ok(products);
        }

        public IHttpActionResult Post(Product product)
        {
            if (ModelState.IsValid)
            {
                _products.Push(product);
                return Created("/api/products/", product);
                //return Ok(new { success = true, message = "Created Successfully!" });
            }

            return BadRequest(ModelState);
        }
    }
}
