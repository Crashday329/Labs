using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class FreqClass
    {
        public FreqClass(double xvalue)
        {
            this.Xvalue = xvalue;
        }
        public double Xvalue { get; set; }

        public double Freq { get; set; } = 0;
    }
}
