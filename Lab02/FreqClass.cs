using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class FreqClass
    {
        double xvalue;
        double freq=0;
        public FreqClass(double xvalue)
        {
            this.xvalue = xvalue;
        }
        public double Xvalue { get => xvalue; set => xvalue = value; }
        public double Freq { get => freq; set => freq = value; }
    }
}
