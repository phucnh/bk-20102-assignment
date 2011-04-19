using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ZedGraph;

using AudioUtils;

namespace XLTN
{
    public partial class TestGraph : Form
    {
        private AudioUtils.WaveFile waveFile;

        public TestGraph()
        {
            InitializeComponent();
        }

        private void DrawGraph()
        {
            GraphPane graphPane = zedGraphControl.GraphPane;
            graphPane.Clone();
            graphPane.XAxis.Title.Text = "Time";
            graphPane.YAxis.Title.Text = "Amplitude";

            PointPairList list = ConvertToPointPairList(waveFile);

            if (list == null) return;

            LineItem curve = graphPane.AddCurve("Curve", list, Color.Red, SymbolType.None);
            curve.Line.Width = 2.0F;
            //curve.Line.Fill = new Fill(Color.White, Color.Red, 45F);
            zedGraphControl.AxisChange();
        }

        private PointPairList ConvertToPointPairList(AudioUtils.WaveFile file)
        {
            if (file == null) return null;

            PointPairList list = new PointPairList();

            double height = zedGraphControl.Height / 4;

            for (int i = 0; i < file.WaveData.NumSamples; i++)
            {
                double val = file.WaveData[i];
                double x = (double)((double)i / (double)(file.WaveFmt.SamplesPerSec)*1000);
                double y = val;

                list.Add(x, y);
            }

            return list;
        }

        protected void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                waveFile = new AudioUtils.WaveFile(openFileDialog1.FileName);

                waveFile.Read();
                //isDraw = true;

                //DrawGraph();
                DrawEngeryGraph();
            }
        }

        protected void DrawEngeryGraph()
        {
            HammingWindow hammingWindow = new HammingWindow(Parameters.HAMMING_WINDOW_WIDE);
                Processor processor = new Processor(waveFile, hammingWindow);

                processor.Process();

            GraphPane graphPane = zedGraphControl.GraphPane;
            graphPane.Clone();
            graphPane.XAxis.Title.Text = "Time";
            graphPane.YAxis.Title.Text = "Amplitude";

            PointPairList list = ConvertEnegryToPointPairList(processor.enegryArray.ToArray());

            if (list == null) return;

            LineItem curve = graphPane.AddCurve("Curve", list, Color.Red, SymbolType.None);
            curve.Line.Width = 2.0F;
            //curve.Line.Fill = new Fill(Color.White, Color.Red, 45F);
            zedGraphControl.AxisChange();
        }

        protected PointPairList ConvertEnegryToPointPairList(double[] array)
        {

            PointPairList list = new PointPairList();

            double height = zedGraphControl.Height / 4;

            for (int i = 0; i < array.Length; i++)
            {
                double val = array[i];
                //double x = (double)((double)i / (double)(file.WaveFmt.SamplesPerSec)*1000);
                double y = val;

                list.Add(i, y);
            }

            return list;
        }

    }
}
