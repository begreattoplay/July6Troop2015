using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfanityCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            ProfanityCleaner cleaner = new ProfanityCleaner();

            string cleanedWord = cleaner.Clean("darn");

            Debug.Assert(cleanedWord == "d**n");
        }
    }
}
