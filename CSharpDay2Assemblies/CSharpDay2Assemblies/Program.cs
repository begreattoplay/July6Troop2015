using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2Assemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            Product marker = new Product
            {
                Name = "Expo",
                Price = 4.99m
            };

            decimal tax = marker.CalculateTax(State.TX);
            Console.WriteLine("The tax is " + tax);

            //pause
            Console.ReadLine();
        }
    }
}
