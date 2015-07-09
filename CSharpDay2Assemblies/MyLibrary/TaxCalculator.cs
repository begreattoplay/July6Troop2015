using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    internal class TaxCalculator
    {
        internal static decimal Calculate(State state, decimal price)
        {
            switch (state)
            {
                case State.CA:
                    return price * 0.08m;
                case State.TX:
                    return price * 0.02m;
                case State.WA:
                    return price * 0.09m;
                default:
                    return price;
            }
        }
    }
}
