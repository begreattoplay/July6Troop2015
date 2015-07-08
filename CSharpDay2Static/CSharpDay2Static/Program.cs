using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2Static
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Utility.CleanUserInput(" aDASDFfdfas   ");
        }
    }

    class Utility
    {
        //Static method
        public static string CleanUserInput(string input)
        {
            return input.ToLower().Trim();
        }
    }
}
