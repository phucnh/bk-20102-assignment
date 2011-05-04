using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ZedGraph;

namespace XLTN
{
    public partial class EnegryGraph : Form
    {

        private AudioUtils.WaveFile waveFile;

        private EnegryGraph()
        {
            InitializeComponent();
        }

        public EnegryGraph(AudioUtils.WaveFile waveFile)
            : this()
        {
            this.waveFile = waveFile;
            //this.waveFile.Read();
        }

        protected void DrawEngeryGraph()
        {
            HammingWindow hammingWindow = new HammingWindow(Parameters.HAMMING_WINDOW_WIDE);
            Processor processor = new Processor(waveFile, hammingWindow);

            processor.Process(); processor.EndPointDetect();

            GraphPane graphPane = zedGraphControl.GraphPane;
            graphPane.Clone();
            graphPane.XAxis.Title.Text = "Time";
            graphPane.YAxis.Title.Text = "Amplitude";

            PointPairList list = Utility.ConvertEnegryToPointPairList(processor.enegryArray.ToArray());

            if (list == null) return;

            LineItem curve = graphPane.AddCurve("Enegry", list, Color.Red, SymbolType.None);


            if (processor.endPointList != null)
            {
                foreach (int end in processor.endPointList)
                {
                    double x = Parameters.HAMMING_WINDOW_WIDE / 2 + end * (Parameters.HAMMING_WINDOW_WIDE - Parameters.COVERED_WIDE);
                    PointPairList endList = new PointPairList();
                    endList.Add(x, 0);
                    endList.Add(x, 500000000);

                    LineItem line = graphPane.AddCurve("Endpoint", endList, Color.Blue, SymbolType.None);
                    line.Line.Width = 3F;
                }
            }

            curve.Line.Width = 1F;
            //curve.Line.Fill = new Fill(Color.White, Color.Red, 45F);
            zedGraphControl.AxisChange();
        }
        
        private void EnegryGraph_Load(object sender, EventArgs e)
        {
            DrawEngeryGraph();
        }


    }
}
