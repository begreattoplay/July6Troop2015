using FirstProject.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //****Checking for file example****
            //if (File.Exists(@"HelloWorld.txt"))
            //{
            //    Console.WriteLine("File exists!!");
            //}

            //****Convert string to number example****
            Console.WriteLine("Enter the first number:");
            int firstNum = 0;
            bool firstNumIsNumber = int.TryParse(Console.ReadLine(), out firstNum);

            Console.WriteLine("Enter the second number:");
            int secondNum = 0;
            bool secondNumIsNumber = int.TryParse(Console.ReadLine(), out secondNum);

            //display result
            if (firstNumIsNumber && secondNumIsNumber)
            {
                int result = firstNum + secondNum;
                Console.WriteLine("The result is " + result.ToString());
            }
            else
            {
                Console.WriteLine("You did not enter valid numbers!");
            }

            //****Switch Statement Example****
            //DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;

            //string dinner = "";

            //switch (dayOfWeek)
            //{
            //    case DayOfWeek.Monday:
            //        dinner = "Steak";
            //        break;
            //    case DayOfWeek.Tuesday:
            //        dinner = "Chicken";
            //        break;
            //    default:
            //        dinner = "Pasta";
            //        break;
            //}

            //Console.WriteLine(dinner);

            Console.ReadLine();
        }
    }
}
