using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class FreqClass
    {
        double _xvalue;
        double _freq=0;
        public FreqClass(double xvalue)
        {
            this._xvalue = xvalue;
        }
        public double Xvalue { get => _xvalue; set => _xvalue = value; }
        public double Freq { get => _freq; set => _freq = value; }
    }
}
