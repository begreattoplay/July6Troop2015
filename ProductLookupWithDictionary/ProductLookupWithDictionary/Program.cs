using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate new instance of a ProductCatalog
            ProductCatalog catalog = new ProductCatalog();

            //Attempt to find a product by the id P2
            Product product = catalog.Lookup("P2");

            //Test that it was found
            Debug.Assert(product != null, "Product with Id P2 not found");
        }
    }
}
