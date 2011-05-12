using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XLTN
{
    public class SquareWindow : WindowFunction
    {
        private uint wide;

        public uint Wide
        {
            get { return wide; }
            set { wide = value; }
        }

        public SquareWindow()
        {}

        public SquareWindow(uint wide)
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
            return 1;
        }
    }
}
