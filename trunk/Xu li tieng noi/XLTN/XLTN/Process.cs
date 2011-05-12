using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XLTN
{
    public class Processor
    {
        private AudioUtils.WaveFile waveFile;
        private WindowFunction hammingWindow;
        public LinkedList<double> enegryArray;
        public List<double> endPointList;

        protected Processor()
        {
            waveFile = null;
            hammingWindow = null;
            enegryArray = null;
            endPointList = new List<double>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Processor"/> class.
        /// </summary>
        /// <param name="waveFile">The wave file.</param>
        /// <param name="hammingWindow">The hamming window.</param>
        public Processor(AudioUtils.WaveFile waveFile, WindowFunction hammingWindow)
            : this()
        {
            this.waveFile = waveFile;
            this.hammingWindow = hammingWindow;

            if (hammingWindow == null) hammingWindow = Utility.CreateWindow();
        }

        /// <summary>
        /// Processes this instance.
        /// </summary>
        public void Process()
        {
            uint jumpStep = Parameters.HAMMING_WINDOW_WIDE - Parameters.COVERED_WIDE;

            ulong signalLength = (ulong)waveFile.WaveData.NumSamples;

            //for (int i = 0; i < waveFile.WaveData.NumSamples; i++)
            //{
            //    waveFile.WaveData[i] = waveFile.WaveData[i] / waveFile.AbsMax;
            //}

            float[] hammingArray = hammingWindow.CalculateData();

            for (ulong i = 0; i < signalLength; i += jumpStep)
            {
                if (i > signalLength)
                {
                    //TODO: Implement if i > numsamples;
                }
                else
                {
                    short[] tempSource = new short[hammingWindow.Wide];
                    Array.Copy(this.waveFile.WaveData.ConvertToArray(), (long)i, tempSource, 0, (long)hammingWindow.Wide);
                    double[] frame = Utility.MultipleSignal(tempSource, hammingArray);

                    if (enegryArray == null) enegryArray = new LinkedList<double>();

                    enegryArray.AddLast(Utility.CalculateEnegry(frame));
                }
            }
        }

        /// <summary>
        /// Ends the point detect.
        /// </summary>
        public void EndPointDetect()
        {
            double[] eArray = enegryArray.ToArray();

            for (int i = 0; i < eArray.Length - 1;)
            {
                int length = 0;

                if (eArray[i] <= Parameters.QUITE)
                {
                    float temp = i;
                    length = 0;

                    int begin = i;

                    while (eArray[i] <= Parameters.QUITE)
                    {
                        length++;
                        i++;

                        if (i == eArray.Length) break;
                    }

                    endPointList.Add(begin);
                    endPointList.Add(i-1);
                }
                else 
                    i++;
            }
        }

        public int ActivityDetect()
        {
            double[] eArray = enegryArray.ToArray();

            for (int i = 0; i < eArray.Length; i++)
            {
                if (eArray[i] > Parameters.ACTIVITY)
                    return i;
            }

            return -1;
        }


    }

    public static class Parameters
    {
        public static uint HAMMING_WINDOW_WIDE = 300;
        public static uint COVERED_WIDE = 100;
        public static double QUITE = 8800000;
        public static double ACTIVITY = 9000000;
        public static WindowType WINDOW_TYPE = WindowType.Hamming;
    }
}
