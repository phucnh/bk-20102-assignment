using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XLTN
{
    public class HammingWindow
    {
        private uint wide;

        public uint Wide
        {
            get { return wide; }
            set { wide = value; }
        }

        public double CaculateN(uint n)
        {
            return (double)(0.54 - 0.46 * Math.Cos(2*Math.PI*(double)(n/Wide)));
        }
    }
}
