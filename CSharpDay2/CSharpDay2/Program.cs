using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string productName = "Laptop";
            //decimal price = 344.55m;
            
            ////concatenation
            //string message = "The " + productName + " costs " + price.ToString() + " dollars.";
            //Console.WriteLine(message);

            ////string format - interpolation
            //string message2 = string.Format("The {0} costs {1:c} dollars.", productName, price);
            //Console.WriteLine(message2);


            string[] colors = new string[] {
                "Blue",
                "Red",
                "Green"
            };

            int[] numbers = new int[] { 2, 32, 7, 89, 4329 };

            Array.Sort(colors);
            Console.WriteLine(colors[1]);



            //pause
            Console.ReadLine();
        }
    }
}
