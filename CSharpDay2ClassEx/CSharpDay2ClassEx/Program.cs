using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2ClassEx
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal CalculateTax()
        {
            return this.CalculateTax(0, 0);
        }

        public decimal CalculateTax(decimal taxRate)
        {
            return this.CalculateTax(taxRate, 0);
        }

        public decimal CalculateTax(decimal taxRate, decimal discount)
        {
            return this.Price + (this.Price * taxRate) - (this.Price * discount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Name = "Milk",
                Price = 5.43m
            };

            Product product2 = new Product
            {
                Name = "Eggs",
                Price = 1.33m
            };
            //Console.WriteLine(string.Format("{0}: {1:c} + {2:c} tax", product1.Name, product1.Price, product1.CalculateTax(0.08m, 10)));

            product1.CalculateTax();
            product1.CalculateTax(0.08m);
            product1.CalculateTax(0.08m, 1.0m);

            //pause
            Console.ReadLine();
        }
    }
}
