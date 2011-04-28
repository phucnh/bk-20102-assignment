using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XLTN
{
    public partial class MainForm : Form
    {
        private AudioUtils.WaveFile waveFile;
        private bool isDraw = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                waveFile = new AudioUtils.WaveFile(openFileDialog1.FileName);
                waveFile.Read();

                this.btnSignalGraph.Enabled = true;
                this.btnEnegryGraph.Enabled = true;
                this.btnShowAll.Enabled = true;
                this.Refresh();
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignalGraph_Click(object sender, EventArgs e)
        {
            SignalGraph frm = new SignalGraph(waveFile);
            frm.Show();
        }

        private void btnEnegryGraph_Click(object sender, EventArgs e)
        {
            EnegryGraph frm = new EnegryGraph(waveFile);
            frm.Show();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            AllGraph frm = new AllGraph(waveFile);
            frm.Show();
        }
    }
}
