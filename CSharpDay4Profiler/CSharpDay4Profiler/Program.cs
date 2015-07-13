using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay4Profiler
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class ProductComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Id - y.Id;
        }
    }

    class Program
    {
        static List<Product> CreateProducts(int count)
        {
            List<Product> products = new List<Product>();
            var rnd = new Random();
            for (var i = 0; i < 1000; i++)
            {
                products.Add(new Product
                {
                    Id = rnd.Next(100),
                    Name = "Product " + i
                });
            }

            return products;
        }

        static Product FindDuplicateProduct(List<Product> products)
        {
            foreach(var product1 in products)
            {
                foreach(var product2 in products)
                {
                    if (product1 != product2 && product1.Id == product2.Id)
                    {
                        return product1;
                    }
                }
            }

            return null;
        }

        static void SortProducts(List<Product> products)
        {
            products.Sort(new ProductComparer());
        }

        static void Main(string[] args)
        {
            // Create 1 thousand products with duplicate ids
            var products = CreateProducts(1000);

            // Remove all products with duplicate ids
            var dup = FindDuplicateProduct(products);
            while (dup != null)
            {
                products.Remove(dup);
                dup = FindDuplicateProduct(products);
            }

            // Sort products
            SortProducts(products);

            // Show unique list of products
            foreach (var product in products)
            {
                Console.WriteLine(product.Id + " is unique.");
            }

            //pause
            Console.ReadLine();
        }
    }
}
