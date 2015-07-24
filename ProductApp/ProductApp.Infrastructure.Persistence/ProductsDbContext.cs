using ProductApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Infrastructure.Persistence
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext()
            : base("ProductsAppDemo")
        {

        }
        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Product> Products { get; set; }
    }
}
