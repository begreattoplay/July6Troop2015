using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay4Async
{
    class Program
    {
        static void Main(string[] args)
        {
            //Block synchronously until the task is completed
            DoSomething();

            Console.ReadLine();
        }


        public async static Task DoSomething()
        {
            var client = new HttpClient();
            string page = await client.GetStringAsync("http://www.microsoft.com");
            Console.WriteLine(page);
        }
    }
}
