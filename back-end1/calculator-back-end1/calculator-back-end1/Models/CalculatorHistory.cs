using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculator_back_end1.Models
{
    public class CalculatorHistory
    {
        public long Id { get; set; }
        public string Operation { get; set; }
        public string Result { get; set; }
    }
}
