using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterTryParse
{
    public static class StringExtensions
    {
        public static int? TryParseToInt(this string value)
        {
            int number = 0;
            if (int.TryParse(value, out number))
                return number;
            else
                return null;

            return int.TryParse(value, out number) ? number : default(int?);
        }
    }
}
