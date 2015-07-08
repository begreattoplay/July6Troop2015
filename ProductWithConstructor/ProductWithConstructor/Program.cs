using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pb = new Product("Jiffy", 2.99m, 10);
            Product jelly = new Product("Welchs", 3.99m, 12, "Good stuff");
            pb.Name = "Reeses";
            //pb.Description = "good stuff too";

            Console.WriteLine(pb.Name);
            Console.ReadLine();
        }
    }

    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public string Description { get; private set; }

        public Product(string name, decimal price, int unitsInStock) : this(name, price, unitsInStock, null)
        {
            
        }
        
        public Product(string name, decimal price, int unitsInStock, string description)
        {
            Name = name;
            Price = price;
            UnitsInStock = unitsInStock;
            Description = description;
        }
    }
}
