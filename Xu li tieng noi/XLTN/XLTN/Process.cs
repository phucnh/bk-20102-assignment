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

        protected Processor()
        {
            waveFile = null;
            hammingWindow = null;
            enegryArray = null; 
        }

        public Processor(AudioUtils.WaveFile waveFile, HammingWindow hammingWindow) : this()
        {
            this.waveFile = waveFile;
            this.hammingWindow = hammingWindow;

            if (hammingWindow == null) hammingWindow = new HammingWindow(Parameters.HAMMING_WINDOW_WIDE);
        }

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
    }

    public static class Parameters
    {
        public static uint HAMMING_WINDOW_WIDE = 50;
        public static uint COVERED_WIDE = 20;
        public static double QUITE = 0;
    }
}
