using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay3GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Name = "Bill Gates" });
            customers.Add(new Customer { Name = "Steve Jobs" });

            Customer customer1 = customers[0];

            List<int> numbers = new List<int>();
            numbers.Add(40);
            numbers.Add(48574);
            //customers.Add()

            foreach (Customer item in customers)
            {
                if (item is Customer)
                {
                    Console.WriteLine(item.Name);
                }
            }

            Console.ReadLine();
        }
    }
}
