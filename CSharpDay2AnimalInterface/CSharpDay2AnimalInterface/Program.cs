using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2AnimalInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear b = new Bear
            {
                Name = "Smokey"
            };

            Eagle e = new Eagle
            {
                Name = "Neat"
            };

            Chicken c = new Chicken
            {
                Name = "Foghorn Leghorn"
            };

            AnimalUtility.DoSomething(c);
            AnimalUtility.DoSomething(e);
            AnimalUtility.DoSomething(b);

            Console.ReadLine();
        }
    }
}
