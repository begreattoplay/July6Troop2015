using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithDictionary
{
    class ProductCatalog
    {
        #region Private Class Instance Fields/Variables

        private Dictionary<string, Product> _products;

        #endregion

        #region Constructors

        public ProductCatalog()
        {
            _products = new Dictionary<string, Product>();

            _products.Add("P1", new Product { Id = "P1", Name = "Peanut Butter", Price = 3.00m });
            _products.Add("P2", new Product { Id = "P2", Name = "Jelly", Price = 2.99m });
            _products.Add("P3", new Product { Id = "P3", Name = "Cookie", Price = 1.50m });
        }

        #endregion

        #region Instance Methods

        public Product Lookup(string id)
        {
            //This will bomb if the id doesn't exist in the dictionary!!
            return _products[id];
        }

        #endregion
    }
}
