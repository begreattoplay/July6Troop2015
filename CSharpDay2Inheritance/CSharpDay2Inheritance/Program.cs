using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            NewCar tesla = new NewCar();
            tesla.Model = "Model S";
            tesla.Price = 283473472983742.239844m;
            tesla.VIN = "2387429837293";

            UsedCar usedToyota = new UsedCar();
            usedToyota.Price = 8734.273m;
            usedToyota.CalculateTax();

            CertifiedUsedCar jaguar = new CertifiedUsedCar();

            Car[] inventory = new Car[] 
            { 
                new UsedCar { VIN = "234982738", Price = 17000m },
                new CertifiedUsedCar { VIN = "7873483", Price = 17000m },
                new NewCar { VIN = "37f83723", Price = 44000m },
                new UsedCar { VIN = "e72338574", Price = 12000m },
                new UsedCar { VIN = "9723874538", Price = 11000m }
            };

            decimal total = 0;
            foreach(Car car in inventory)
            {
                if (car is UsedCar)
                {
                    total = total + car.Price;
                }
            }

            Console.WriteLine("Total inventory value: " + total.ToString("c"));
            Console.ReadLine();
        }
    }

    abstract class Car
    {
        public string VIN { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public decimal CalculateTax()
        {
            return this.Price * 0.08m;
        }
    }

    class NewCar : Car
    {
    }

    class UsedCar : Car
    {
        public int Miles { get; set; }
    }

    class CertifiedUsedCar : UsedCar
    {
        public int WarrantyMonths { get; set; }
    }
}
