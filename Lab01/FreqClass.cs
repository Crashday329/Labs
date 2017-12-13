using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class FreqClass
    {
        public string Xvalue { get; set; }

        public double LeftRange { get; set; }
        public double RightRange { get; set; }

        public double Freq { get; set; } = 0;

        public FreqClass(string xvalue)
        {
            this.Xvalue = xvalue;
        }
            }
}
