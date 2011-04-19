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

        private HammingWindow()
        { }

        public HammingWindow(uint wide)
            : this()
        {
            this.Wide = wide;
        }

        public float[] CalculateData()
        {
            float[] result = new float[Wide];
            //float[] value = new float[Wide];

            for (uint i = 0; i < Wide; i++)
            {
                //value[i] = CaculateN(i);
                result[i] = CaculateN(i);
            }

            return result;
        }


        public float CaculateN(uint n)
        {
            return (float)(0.54 - 0.46 * Math.Cos(2 * 90 * ((float)n / (Wide - 1))));
        }
    }
}
