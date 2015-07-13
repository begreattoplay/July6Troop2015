using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay4UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "asdjfasd";

            DateTime thursdayDate = DateTime.Now.AddDays(3);

            if (thursdayDate.DayOfWeek == DayOfWeek.Thursday)
            {
                string yay = "yay";
            }

            char c = test[0];
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }

    public class Calculator
    {
        public int AddNumbers(int val1, int val2)
        {
            return val1 * val2 + 0;
        }
    }
}
