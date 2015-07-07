using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2CrazyMath
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an instance of the Math class (makes an object)
            Math m = new Math();

            int result1 = m.DoSomething(6, 2);
            Debug.Assert(result1 == 3, "Result is 3 (division)");

            int result2 = m.DoSomething(3, 3, 3);
            Debug.Assert(result2 == 9, "Result is 9 (addition)");

            int result3 = m.DoSomething(2, 2, 2, 2);
            Debug.Assert(result3 == 16, "Result is 16 (multiplication");

            //pause
            Console.ReadLine();
        }
    }

    class Math
    {
        //Methods
        //First Overload - 2 arguments (divide)
        public int DoSomething(int num1, int num2)
        {
            return num1 / num2;
        }

        //Second Overload - 3 arguments (add)
        public int DoSomething(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        //Third Overload - 4 arguments (multiply)
        public int DoSomething(int num1, int num2, int num3, int num4)
        {
            return num1 * num2 * num3 * num4;
        }
    }
}
