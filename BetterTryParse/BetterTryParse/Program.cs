using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = "45";
            string value2 = "Peanut Butter";

            int? result1 = value1.TryParseToInt();
            int? result2 = value2.TryParseToInt();

            if (result1 != null)
                Console.WriteLine("Successfully parsed: " + result1);
            else
                Console.WriteLine("Unable to parse " + value1);

            if (result2 != null)
                Console.WriteLine("Successfully parsed: " + result2);
            else
                Console.WriteLine("Unable to parse " + value2);

            //pause
            Console.ReadLine();
        }
    }
}
