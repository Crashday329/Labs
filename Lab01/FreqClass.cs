using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class FreqClass
    {
        string xvalue;
        double freq=0;

        public string Xvalue
        {
            get
            {
                return xvalue;
            }

            set
            {
                xvalue = value;
            }
        }

        public double Freq
        {
            get
            {
                return freq;
            }

            set
            {
                freq = value;
            }
        }

        public FreqClass(string xvalue)
        {
            this.Xvalue = xvalue;
        }
            }
}
