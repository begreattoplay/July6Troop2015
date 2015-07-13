using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay4TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                File.AppendAllText("c:\\Notes.txt", "Hello, World!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadLine();
        }
    }
}
