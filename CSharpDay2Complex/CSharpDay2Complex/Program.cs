using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer
            {
                BillingAddress =
                {
                    City = "Houston",
                    Street = "3242 asdf",
                    ZIP = "3423"
                },
                ShippingAddress =
                {
                    City = "Pearland",
                    Street = "23984",
                    ZIP = "@3432"
                },
                FirstName = "Nick",
                LastName = "Brittain"
            };

            Customer cust2 = new Customer();
            cust2.BillingAddress.City = "Houston";
            cust2.BillingAddress.Street = "234323";
            cust2.BillingAddress.ZIP = "238423";
            cust2.FirstName = "Nick";
        }
    }

    class Customer
    {
        public Customer()
        {
            BillingAddress = new Address();
            ShippingAddress = new Address();
            DateCreated = DateTime.Now;
        }

        public Customer(string firstName, string lastName, string billingStreet, string billingCity, string billingZip, string shippingCity)
        {
            BillingAddress.Street = billingStreet;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public DateTime DateCreated { get; set; }

    }

    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZIP { get; set; }
    }
}
