using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XLTN
{
    public class Utility
    {
        public static int[] Convolution(byte[] source1, byte[] source2)
        {
            int n = Math.Min(source1.Length, source2.Length);
            int[] result = new int[n];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    byte s1, s2;

                    if (j >= source1.Length) s1 = 0;
                    else s1 = source1[j];

                    if ((n - j) >= source2.Length) s2 = 0;
                    else s2 = source2[n - j];

                    result[i] += s1 * s2;
                }
            }

            return result;
        }

        public static double[] CalculateEnegry(byte[] source)
        {
            int length = source.Length;
            double[] result = new double[length];

            for (int i = 0; i < length; i++)
            {
                result[i] =(double) source[i] * source[i];
            }

            return result;
        }

        public static double CalculateEnegryAtN(Int16 source)
        {
            return (double)source * source;
        }

    }
}
