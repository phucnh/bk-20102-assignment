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
                isDraw = true;

                Refresh();
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(ForeColor);

            if (isDraw)
            {
                waveFile.Draw(e, pen);
            }
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (e.Delta * SystemInformation.MouseWheelScrollLines / 120 > 0)
            {
                waveFile.ZoomIn();
            }
            else
            {
                waveFile.ZoomOut();
            }

            Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
