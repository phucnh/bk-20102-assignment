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
                
                this.Refresh();
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            txtWindowWide.Text = Parameters.HAMMING_WINDOW_WIDE.ToString();
            txtCoveredWide.Text = Parameters.COVERED_WIDE.ToString() ;
            txtQuite.Text = Parameters.QUITE.ToString();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Parameters.HAMMING_WINDOW_WIDE = Convert.ToUInt32(txtWindowWide.Text);
            Parameters.COVERED_WIDE = Convert.ToUInt32(txtCoveredWide.Text);
            Parameters.QUITE = Convert.ToUInt32(txtQuite.Text);
        }
    }
}
