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

                txtFormatID.Text = "fmt (" + waveFile.WaveFmt.FmtID[0] + " " + waveFile.WaveFmt.FmtID[1] + " " + waveFile.WaveFmt.FmtID[2] + " " + waveFile.WaveFmt.FmtID[3] + ")";
                txtFormatSize.Text = waveFile.WaveFmt.FmtSize.ToString();
                txtAudioFormat.Text = waveFile.WaveFmt.FmtTag.ToString();
                txtNumberChannels.Text = waveFile.WaveFmt.Channels.ToString();
                txtSampleRate.Text = waveFile.WaveFmt.SamplesPerSec.ToString();
                txtByteRate.Text = waveFile.WaveFmt.AverageBytesPerSec.ToString();
                txtBlockAlign.Text = waveFile.WaveFmt.BlockAlign.ToString();
                txtBitsPerSample.Text = waveFile.WaveFmt.BitsPerSample.ToString();

                txtDataID.Text = "data(" + waveFile.WaveData.DataID[0] + " " + waveFile.WaveData.DataID[1] + " " + waveFile.WaveData.DataID[2] + " " + waveFile.WaveData.DataID[3] + ")";
                txtDataSize.Text = waveFile.WaveData.DataSize.ToString();
                txtData.Text = waveFile.WaveData.NumSamples.ToString();
                
                this.btnSignalGraph.Enabled = true;
                this.btnEnegryGraph.Enabled = true;
                this.btnDetect.Enabled = true;
                
                this.Refresh();
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            txtWindowWide.Text = Parameters.HAMMING_WINDOW_WIDE.ToString();
            txtCoveredWide.Text = Parameters.COVERED_WIDE.ToString() ;
            txtQuite.Text = Parameters.QUITE.ToString();
            txtActivity.Text = Parameters.ACTIVITY.ToString();

            if (Parameters.WINDOW_TYPE == WindowType.Hamming)
            {
                rbtnHamming.Checked = true;
                rbtnSquare.Checked = false;
            }
            else
            {
                rbtnHamming.Checked = false;
                rbtnSquare.Checked = true;
            }

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
            Parameters.QUITE = Convert.ToDouble(txtQuite.Text);
            Parameters.ACTIVITY = Convert.ToDouble(txtActivity.Text);

            if (rbtnHamming.Checked)
            {
                Parameters.WINDOW_TYPE = WindowType.Hamming;
            }
            else
            {
                Parameters.WINDOW_TYPE = WindowType.Square;
            }

            MessageBox.Show("Success!!!");
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            Detect frm = new Detect(waveFile);
            frm.Show();
        }
    }
}
