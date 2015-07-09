using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2Extensions
{
    class Program
    {
        static void Increment(ref int num)
        {
            num++;
        }

        static void Main(string[] args)
        {
            int num = 10;
            Increment(ref num);
            Console.WriteLine(num);


            string message = "Everything is Awesome!".Reverse();
            //string revMessage = StringUtility.Reverse(message);
            Console.WriteLine(message);
            
            //pause
            Console.ReadLine();
        }
    }

    class StringUtility
    {
        public static string Reverse(string text)
        {
            Char[] textArray = text.ToCharArray();
            Array.Reverse(textArray);
            return new String(textArray);
        }
    }

    static class StringExtensions
    {
        public static string Reverse(this string stringToExtend)
        {
            Char[] textArray = stringToExtend.ToCharArray();
            Array.Reverse(textArray);
            return new String(textArray);
        }
    }
}
