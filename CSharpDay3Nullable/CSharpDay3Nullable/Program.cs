using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay3Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee
            {
                Name = "Bill Gates",
                Startdate = DateTime.Parse("April 4, 1975")
            };


            DateTime endDate = employee1.EndDate.HasValue ? employee1.EndDate.Value : DateTime.Now;

            if (employee1.EndDate != null)
            {
                Console.WriteLine("End date was " + employee1.EndDate);
            }

            if (employee1.EndDate.HasValue)
            {
                Console.WriteLine("End date was " + employee1.EndDate);
            }


            int result = 0;

            if (int.TryParse("4545", out result))
            {
                Console.WriteLine("Parsed your value successfully");
            }
            else
            {
                Console.WriteLine("Sorry, I was unable to parse your value into an INT");
            }


            //pause
            Console.ReadLine();
        }
    }
}
