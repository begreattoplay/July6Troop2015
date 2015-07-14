using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //7 instances of cat
            string message = "cat somewhere there is a cat with a cat in the hat next to a cat and another cat named cat i wish I was a cat";

            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = CountCats2(message);
            timer.Stop();

            Console.WriteLine("Found {0} instances of 'cat' and it took {1} milliseconds", result, timer.Elapsed.TotalMilliseconds);
            Console.ReadLine();
        }

        static int CountCats(string message)
        {
            //About 1.5 seconds
            return message.Split().Count(s => s == "cat");
        }

        static int CountCats2(string message)
        {
            //About .5 seconds
            int count = 0;
            int i = 0;
            while ((i = message.IndexOf("cat", i)) != -1)
            {
                i += 3;
                count++;
            }

            return count;
        }
    }
}
