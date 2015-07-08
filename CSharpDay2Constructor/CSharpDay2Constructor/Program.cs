using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer("Nick", "Brittain");


            Console.WriteLine(cust1.FirstName);
            Console.WriteLine(cust1.LastName);

            //pause
            Console.ReadLine();
        }
    }

    class Customer
    {
        #region Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }

        #endregion

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
