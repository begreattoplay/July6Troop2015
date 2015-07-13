using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay4Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static decimal CalculateTotalPriceWithTax(decimal price, decimal taxRate)
        {
            if (price < 0)
                throw new ArgumentOutOfRangeException("price", "Price must be greater than 0.");

            if (taxRate < 0)
                throw new ArgumentOutOfRangeException("taxRate", "Tax Rate must be greater than 0.");

            if (taxRate > .1m)
                throw new ArgumentOutOfRangeException("taxRate", "Tax Rate must be less than or equal to 10%");

            return price * taxRate + price;
        }
    }
}
