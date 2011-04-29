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
    public partial class SignalGraph : Form
    {
        private AudioUtils.WaveFile waveFile;

        protected SignalGraph()
        {
            InitializeComponent();
        }

        public SignalGraph(AudioUtils.WaveFile waveFile)
            : this()
        {
            this.waveFile = waveFile;
            //this.waveFile.Read();
        }


        private void DrawGraph()
        {
            GraphPane graphPane = zedGraphControl.GraphPane;
            graphPane.Clone();
            graphPane.XAxis.Title.Text = "Time";
            graphPane.YAxis.Title.Text = "Amplitude";

            PointPairList list = Utility.ConvertToPointPairList(waveFile);

            if (list == null) return;

            LineItem curve = graphPane.AddCurve("", list, Color.Red, SymbolType.None);
            curve.Line.Width = 1F;
            zedGraphControl.AxisChange();
        }

        private void SignalGraph_Load(object sender, EventArgs e)
        {
            DrawGraph();
        }
    }
}
