using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XLTN
{
    public class Processor
    {
        private AudioUtils.WaveFile waveFile;
        private HammingWindow hammingWindow;
        public LinkedList<double> enegryArray;
        public List<double> endPointList;

        protected Processor()
        {
            waveFile = null;
            hammingWindow = null;
            enegryArray = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Processor"/> class.
        /// </summary>
        /// <param name="waveFile">The wave file.</param>
        /// <param name="hammingWindow">The hamming window.</param>
        public Processor(AudioUtils.WaveFile waveFile, HammingWindow hammingWindow)
            : this()
        {
            this.waveFile = waveFile;
            this.hammingWindow = hammingWindow;

            if (hammingWindow == null) hammingWindow = new HammingWindow(Parameters.HAMMING_WINDOW_WIDE);
        }

        /// <summary>
        /// Processes this instance.
        /// </summary>
        public void Process()
        {
            uint jumpStep = Parameters.HAMMING_WINDOW_WIDE - Parameters.COVERED_WIDE;
            ulong signalLength = (ulong)waveFile.WaveData.NumSamples;

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

            for (int i = 0; i < eArray.Length - 1; i++)
            {

                if (eArray[i] < Parameters.QUITE && eArray[i + 1] > Parameters.QUITE)
                {
                    if (endPointList == null) endPointList = new List<double>();

                    endPointList.Add((double)i + .5d);
                }
                else if (eArray[i] > Parameters.QUITE && eArray[i + 1] < Parameters.QUITE)
                {
                    if (endPointList == null) endPointList = new List<double>();

                    endPointList.Add((double)i + .5d);
                }
                else if (eArray[i] == Parameters.QUITE)
                {
                    if (endPointList == null) endPointList = new List<double>();

                    endPointList.Add(i);
                }
            }
        }
    }

    public static class Parameters
    {
        public static uint HAMMING_WINDOW_WIDE = 50;
        public static uint COVERED_WIDE = 20;
        public static double QUITE = 300;
    }
}
