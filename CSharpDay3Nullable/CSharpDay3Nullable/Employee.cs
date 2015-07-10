using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay3Nullable
{
    class Employee
    {
        public string Name { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
