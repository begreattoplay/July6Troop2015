using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public enum State
    {
        CA,
        WA,
        TX
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal CalculateTax(State state)
        {
            return TaxCalculator.Calculate(state, this.Price);
        }
    }
}
