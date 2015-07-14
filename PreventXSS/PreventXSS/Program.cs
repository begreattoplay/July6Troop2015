using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PreventXSS
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "<b>hello</b><script>evil</script>";

            string result = Security.SanitizeHTML(test, new string[] {"b"});

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    public class Security
    {
        public static string SanitizeHTML(string text, params string[] validTags)
        {
            string sanitized = HttpUtility.HtmlEncode(text);

            foreach(var tag in validTags)
            {
                sanitized = sanitized.Replace("&lt;" + tag + "&gt;", "<" + tag + ">");
                sanitized = sanitized.Replace("&lt;/" + tag + "&gt;", "<" + tag + ">");
                
            }

            return sanitized;
        }
    }
}
