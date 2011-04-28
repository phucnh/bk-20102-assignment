using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ZedGraph;

namespace XLTN
{
    public class Utility
    {
        public static int[] Convolution(short[] source1, short[] source2)
        {
            int n = Math.Min(source1.Length, source2.Length);
            int[] result = new int[n];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    short s1, s2;

                    if (j >= source1.Length) s1 = 0;
                    else s1 = source1[j];

                    if ((n - j) >= source2.Length) s2 = 0;
                    else s2 = source2[n - j];

                    result[i] += s1 * s2;
                }
            }

            return result;
        }

        public static double[] MultipleSignal(short[] source1, float[] source2)
        {
            int length = Math.Min(source1.Length, source2.Length);
            double[] result = new double[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = source1[i]*source2[i];
            }

            return result;
        }

        public static double CalculateEnegry(short[] source)
        {
            int length = source.Length;
            double result = 0.0d;

            for (int i = 0; i < length; i++)
            {
                result +=(double) source[i] * source[i];
            }

            return result;
        }

        public static double CalculateEnegry(double[] source)
        {
            int length = source.Length;
            double result = 0.0d;

            for (int i = 0; i < length; i++)
            {
                result += (double)source[i] * source[i];
            }

            return result;
        }

        public static double CalculateEnegryAtN(Int16 source)
        {
            return (double)source * source;
        }


        public static PointPairList ConvertToPointPairList(AudioUtils.WaveFile file)
        {
            if (file == null) return null;

            PointPairList list = new PointPairList();

            //double height = zedGraphControl.Height / 4;

            for (int i = 0; i < file.WaveData.NumSamples; i++)
            {
                double val = file.WaveData[i];
                //double x = (double)((double)i / (double)(file.WaveFmt.SamplesPerSec) * 1000);
                double y = val;

                list.Add(i, y);
            }

            return list;
        }

        public static PointPairList ConvertEnegryToPointPairList(double[] array)
        {

            PointPairList list = new PointPairList();

            //double height = zedGraphControl.Height / 4;

            for (int i = 0; i < array.Length; i++)
            {
                double val = array[i];
                double x = Parameters.HAMMING_WINDOW_WIDE / 2 + i * (Parameters.HAMMING_WINDOW_WIDE - Parameters.COVERED_WIDE);
                double y = val;

                list.Add(x, y);
            }

            return list;
        }

    }
}
