using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNetDay4DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgrammingLanguagesEntities db = new ProgrammingLanguagesEntities();

            List<Language> languages = db.Languages.ToList();

            foreach(Language l in languages)
            {
                Console.WriteLine(l.Name);
            }
        }
    }
}
