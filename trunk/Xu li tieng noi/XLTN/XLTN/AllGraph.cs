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
    public partial class AllGraph : Form
    {
        private AudioUtils.WaveFile waveFile;

        private AllGraph()
        {
            InitializeComponent();
        }

        public AllGraph(AudioUtils.WaveFile waveFile)
            : this()
        {
            this.waveFile = waveFile;
        }

        protected void DrawGraph()
        {
            HammingWindow hammingWindow = new HammingWindow(Parameters.HAMMING_WINDOW_WIDE);
            Processor processor = new Processor(waveFile, hammingWindow);

            processor.Process();

            GraphPane sGraphPane = new GraphPane();
            GraphPane eGraphPane = new GraphPane();

            sGraphPane.Clone();
            sGraphPane.XAxis.Title.Text = "Time";
            sGraphPane.YAxis.Title.Text = "Amplitude";

            eGraphPane.Clone();
            eGraphPane.XAxis.Title.Text = "Time";
            eGraphPane.YAxis.Title.Text = "Enegry";

            PointPairList signalList = Utility.ConvertToPointPairList(waveFile);
            PointPairList enegryList = Utility.ConvertEnegryToPointPairList(processor.enegryArray.ToArray());

            if (signalList == null || enegryList == null) return;

            LineItem sCurve = sGraphPane.AddCurve("Signal", signalList, Color.Red, SymbolType.None);
            LineItem eCurve = eGraphPane.AddCurve("Enegry", enegryList, Color.Blue, SymbolType.None);

            sCurve.Line.Width = 2.0F;
            eCurve.Line.Width = 2.0F;

            //curve.Line.Fill = new Fill(Color.White, Color.Red, 45F);
            zedGraphControl.MasterPane.Add(sGraphPane);
            zedGraphControl.MasterPane.Add(eGraphPane);
            zedGraphControl.AxisChange();
        }

        private void AllGraph_Load(object sender, EventArgs e)
        {
            DrawGraph();
        }
    }
}
