using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxRules
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Tax
    {
        private DateTime _date;

        public Tax(DateTime date)
        {
            _date = date;
        }

        public decimal Calculate(decimal amount, DateTime birthDate, string firstName, string lastName)
        {
            decimal taxAmount = 0;

            if ((DateTime.Now.Year - birthDate.Year) < 5)
                return taxAmount;

            taxAmount = amount * .08m;

            if (_date.DayOfWeek == DayOfWeek.Thursday)
                taxAmount += taxAmount;

            if (firstName.ToLower().StartsWith("j"))
                taxAmount += taxAmount;

            if (lastName.ToLower().StartsWith("w"))
                taxAmount -= 1;

            return taxAmount >= 0 ? taxAmount : 0;
        }
    }
}
