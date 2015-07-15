using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAddCalculator.Models
{
    public class IndexViewModel
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Result { get { return Number1 + Number2; } }
    }
}