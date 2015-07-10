using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfanityCleaner
{
    class ProfanityCleaner
    {
        Dictionary<string, string> _cleaner;

        public ProfanityCleaner()
        {
            _cleaner = new Dictionary<string, string>();
            _cleaner.Add("darn", "d**n");
            _cleaner.Add("gosh", "g**h");
            _cleaner.Add("yuck", "y**k");
        }

        public string Clean(string word)
        {
            string foundWord;
            return _cleaner.TryGetValue(word.ToLower().Trim(), out foundWord) ? foundWord : word;            
        }
    }
}
