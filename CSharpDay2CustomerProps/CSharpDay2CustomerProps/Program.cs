using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2CustomerProps
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new instance of a customer named sally using the
            //property initializer syntax
            Customer sally = new Customer
            {
                Age = 20,
                BirthDate = DateTime.Parse("2028-01-01"),
                FirstName = "Sally",
                LastName = "Williams"
            };

            Customer mike = new Customer
            {
                Age = 10,
                BirthDate = DateTime.Parse("2019-01-01"),
                FirstName = "Mike",
                LastName = "Harrison"
            };

            Debug.Assert(sally.Age == 23, "Sally is 23");
            Debug.Assert(mike.Age == 10, "Mike is 10");

            Console.ReadLine();
        }
    }

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Display()
        {
            return string.Format("Name: {0} {1}, Age: {2}, Birth Date: {3}", this.FirstName, this.LastName, this.Age, this.BirthDate);
        }
    }
}
