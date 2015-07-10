using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithList
{
    class ProductCatalog
    {
        List<Product> _products = new List<Product>();

        public ProductCatalog()
        {
            _products.Add(new Product { Id = "UY8890NB", Name = "Peanut Butter", Price = 3.99m });
            _products.Add(new Product { Id = "UY8880NB", Name = "Toast", Price = 1.99m });
            _products.Add(new Product { Id = "UY8870NB", Name = "Honey", Price = 4.89m });
        }

        public Product Lookup(string id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
