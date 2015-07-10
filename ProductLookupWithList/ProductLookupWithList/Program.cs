using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithList
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCatalog catalog = new ProductCatalog();
            Product product1 = catalog.Lookup("UY8890NB");
        }
    }
}
