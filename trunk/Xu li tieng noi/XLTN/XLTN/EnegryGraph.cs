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

            processor.Process();

            GraphPane graphPane = zedGraphControl.GraphPane;
            graphPane.Clone();
            graphPane.XAxis.Title.Text = "Time";
            graphPane.YAxis.Title.Text = "Amplitude";

            PointPairList list = Utility.ConvertEnegryToPointPairList(processor.enegryArray.ToArray());

            if (list == null) return;

            LineItem curve = graphPane.AddCurve("Enegry", list, Color.Red, SymbolType.None);
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
