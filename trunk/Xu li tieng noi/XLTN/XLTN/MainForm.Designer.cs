namespace XLTN
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.Label();
            this.txtDataSize = new System.Windows.Forms.Label();
            this.txtDataID = new System.Windows.Forms.Label();
            this.txtBitsPerSample = new System.Windows.Forms.Label();
            this.txtBlockAlign = new System.Windows.Forms.Label();
            this.txtByteRate = new System.Windows.Forms.Label();
            this.txtSampleRate = new System.Windows.Forms.Label();
            this.txtNumberChannels = new System.Windows.Forms.Label();
            this.txtAudioFormat = new System.Windows.Forms.Label();
            this.txtFormatSize = new System.Windows.Forms.Label();
            this.txtFormatID = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDataSize = new System.Windows.Forms.Label();
            this.lblDataID = new System.Windows.Forms.Label();
            this.lblDataChunk = new System.Windows.Forms.Label();
            this.lblBitsPerSample = new System.Windows.Forms.Label();
            this.lblBlockAlign = new System.Windows.Forms.Label();
            this.lblByteRate = new System.Windows.Forms.Label();
            this.lblSampleRate = new System.Windows.Forms.Label();
            this.lblNumChannels = new System.Windows.Forms.Label();
            this.lblAudioFormat = new System.Windows.Forms.Label();
            this.lblFormatSize = new System.Windows.Forms.Label();
            this.lblFormatID = new System.Windows.Forms.Label();
            this.lblFmtChunk = new System.Windows.Forms.Label();
            this.grpCommand = new System.Windows.Forms.GroupBox();
            this.btnDetect = new System.Windows.Forms.Button();
            this.btnEnegryGraph = new System.Windows.Forms.Button();
            this.btnSignalGraph = new System.Windows.Forms.Button();
            this.grpOption = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoveredWide = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWindowWide = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grpCommand.SuspendLayout();
            this.grpOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpDetails.Controls.Add(this.txtData);
            this.grpDetails.Controls.Add(this.txtDataSize);
            this.grpDetails.Controls.Add(this.txtDataID);
            this.grpDetails.Controls.Add(this.txtBitsPerSample);
            this.grpDetails.Controls.Add(this.txtBlockAlign);
            this.grpDetails.Controls.Add(this.txtByteRate);
            this.grpDetails.Controls.Add(this.txtSampleRate);
            this.grpDetails.Controls.Add(this.txtNumberChannels);
            this.grpDetails.Controls.Add(this.txtAudioFormat);
            this.grpDetails.Controls.Add(this.txtFormatSize);
            this.grpDetails.Controls.Add(this.txtFormatID);
            this.grpDetails.Controls.Add(this.lblData);
            this.grpDetails.Controls.Add(this.lblDataSize);
            this.grpDetails.Controls.Add(this.lblDataID);
            this.grpDetails.Controls.Add(this.lblDataChunk);
            this.grpDetails.Controls.Add(this.lblBitsPerSample);
            this.grpDetails.Controls.Add(this.lblBlockAlign);
            this.grpDetails.Controls.Add(this.lblByteRate);
            this.grpDetails.Controls.Add(this.lblSampleRate);
            this.grpDetails.Controls.Add(this.lblNumChannels);
            this.grpDetails.Controls.Add(this.lblAudioFormat);
            this.grpDetails.Controls.Add(this.lblFormatSize);
            this.grpDetails.Controls.Add(this.lblFormatID);
            this.grpDetails.Controls.Add(this.lblFmtChunk);
            this.grpDetails.Location = new System.Drawing.Point(13, 25);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(443, 313);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "File Details";
            // 
            // txtData
            // 
            this.txtData.AutoSize = true;
            this.txtData.Location = new System.Drawing.Point(132, 285);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(0, 13);
            this.txtData.TabIndex = 23;
            // 
            // txtDataSize
            // 
            this.txtDataSize.AutoSize = true;
            this.txtDataSize.Location = new System.Drawing.Point(132, 263);
            this.txtDataSize.Name = "txtDataSize";
            this.txtDataSize.Size = new System.Drawing.Size(0, 13);
            this.txtDataSize.TabIndex = 22;
            // 
            // txtDataID
            // 
            this.txtDataID.AutoSize = true;
            this.txtDataID.Location = new System.Drawing.Point(132, 240);
            this.txtDataID.Name = "txtDataID";
            this.txtDataID.Size = new System.Drawing.Size(0, 13);
            this.txtDataID.TabIndex = 21;
            // 
            // txtBitsPerSample
            // 
            this.txtBitsPerSample.AutoSize = true;
            this.txtBitsPerSample.Location = new System.Drawing.Point(132, 191);
            this.txtBitsPerSample.Name = "txtBitsPerSample";
            this.txtBitsPerSample.Size = new System.Drawing.Size(0, 13);
            this.txtBitsPerSample.TabIndex = 20;
            // 
            // txtBlockAlign
            // 
            this.txtBlockAlign.AutoSize = true;
            this.txtBlockAlign.Location = new System.Drawing.Point(132, 170);
            this.txtBlockAlign.Name = "txtBlockAlign";
            this.txtBlockAlign.Size = new System.Drawing.Size(0, 13);
            this.txtBlockAlign.TabIndex = 19;
            // 
            // txtByteRate
            // 
            this.txtByteRate.AutoSize = true;
            this.txtByteRate.Location = new System.Drawing.Point(132, 147);
            this.txtByteRate.Name = "txtByteRate";
            this.txtByteRate.Size = new System.Drawing.Size(0, 13);
            this.txtByteRate.TabIndex = 18;
            // 
            // txtSampleRate
            // 
            this.txtSampleRate.AutoSize = true;
            this.txtSampleRate.Location = new System.Drawing.Point(132, 123);
            this.txtSampleRate.Name = "txtSampleRate";
            this.txtSampleRate.Size = new System.Drawing.Size(0, 13);
            this.txtSampleRate.TabIndex = 17;
            // 
            // txtNumberChannels
            // 
            this.txtNumberChannels.AutoSize = true;
            this.txtNumberChannels.Location = new System.Drawing.Point(132, 100);
            this.txtNumberChannels.Name = "txtNumberChannels";
            this.txtNumberChannels.Size = new System.Drawing.Size(0, 13);
            this.txtNumberChannels.TabIndex = 16;
            // 
            // txtAudioFormat
            // 
            this.txtAudioFormat.AutoSize = true;
            this.txtAudioFormat.Location = new System.Drawing.Point(132, 77);
            this.txtAudioFormat.Name = "txtAudioFormat";
            this.txtAudioFormat.Size = new System.Drawing.Size(0, 13);
            this.txtAudioFormat.TabIndex = 15;
            // 
            // txtFormatSize
            // 
            this.txtFormatSize.AutoSize = true;
            this.txtFormatSize.Location = new System.Drawing.Point(132, 55);
            this.txtFormatSize.Name = "txtFormatSize";
            this.txtFormatSize.Size = new System.Drawing.Size(0, 13);
            this.txtFormatSize.TabIndex = 14;
            // 
            // txtFormatID
            // 
            this.txtFormatID.AutoSize = true;
            this.txtFormatID.Location = new System.Drawing.Point(129, 34);
            this.txtFormatID.Name = "txtFormatID";
            this.txtFormatID.Size = new System.Drawing.Size(0, 13);
            this.txtFormatID.TabIndex = 13;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(27, 286);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(96, 13);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "- NumberSamples: ";
            // 
            // lblDataSize
            // 
            this.lblDataSize.AutoSize = true;
            this.lblDataSize.Location = new System.Drawing.Point(27, 264);
            this.lblDataSize.Name = "lblDataSize";
            this.lblDataSize.Size = new System.Drawing.Size(62, 13);
            this.lblDataSize.TabIndex = 11;
            this.lblDataSize.Text = "- DataSize: ";
            // 
            // lblDataID
            // 
            this.lblDataID.AutoSize = true;
            this.lblDataID.Location = new System.Drawing.Point(27, 240);
            this.lblDataID.Name = "lblDataID";
            this.lblDataID.Size = new System.Drawing.Size(50, 13);
            this.lblDataID.TabIndex = 10;
            this.lblDataID.Text = "- DataID:";
            // 
            // lblDataChunk
            // 
            this.lblDataChunk.AutoSize = true;
            this.lblDataChunk.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDataChunk.Location = new System.Drawing.Point(10, 220);
            this.lblDataChunk.Name = "lblDataChunk";
            this.lblDataChunk.Size = new System.Drawing.Size(100, 14);
            this.lblDataChunk.TabIndex = 9;
            this.lblDataChunk.Text = "* The Data Chunk";
            // 
            // lblBitsPerSample
            // 
            this.lblBitsPerSample.AutoSize = true;
            this.lblBitsPerSample.Location = new System.Drawing.Point(27, 192);
            this.lblBitsPerSample.Name = "lblBitsPerSample";
            this.lblBitsPerSample.Size = new System.Drawing.Size(87, 13);
            this.lblBitsPerSample.TabIndex = 8;
            this.lblBitsPerSample.Text = "- BitsPerSample: ";
            // 
            // lblBlockAlign
            // 
            this.lblBlockAlign.AutoSize = true;
            this.lblBlockAlign.Location = new System.Drawing.Point(27, 171);
            this.lblBlockAlign.Name = "lblBlockAlign";
            this.lblBlockAlign.Size = new System.Drawing.Size(69, 13);
            this.lblBlockAlign.TabIndex = 7;
            this.lblBlockAlign.Text = "- BlockAlign: ";
            // 
            // lblByteRate
            // 
            this.lblByteRate.AutoSize = true;
            this.lblByteRate.Location = new System.Drawing.Point(27, 148);
            this.lblByteRate.Name = "lblByteRate";
            this.lblByteRate.Size = new System.Drawing.Size(63, 13);
            this.lblByteRate.TabIndex = 6;
            this.lblByteRate.Text = "- ByteRate: ";
            // 
            // lblSampleRate
            // 
            this.lblSampleRate.AutoSize = true;
            this.lblSampleRate.Location = new System.Drawing.Point(27, 124);
            this.lblSampleRate.Name = "lblSampleRate";
            this.lblSampleRate.Size = new System.Drawing.Size(77, 13);
            this.lblSampleRate.TabIndex = 5;
            this.lblSampleRate.Text = "- SampleRate: ";
            // 
            // lblNumChannels
            // 
            this.lblNumChannels.AutoSize = true;
            this.lblNumChannels.Location = new System.Drawing.Point(27, 101);
            this.lblNumChannels.Name = "lblNumChannels";
            this.lblNumChannels.Size = new System.Drawing.Size(100, 13);
            this.lblNumChannels.TabIndex = 4;
            this.lblNumChannels.Text = "- NumberChannels: ";
            // 
            // lblAudioFormat
            // 
            this.lblAudioFormat.AutoSize = true;
            this.lblAudioFormat.Location = new System.Drawing.Point(27, 78);
            this.lblAudioFormat.Name = "lblAudioFormat";
            this.lblAudioFormat.Size = new System.Drawing.Size(78, 13);
            this.lblAudioFormat.TabIndex = 3;
            this.lblAudioFormat.Text = "- AudioFormat: ";
            // 
            // lblFormatSize
            // 
            this.lblFormatSize.AutoSize = true;
            this.lblFormatSize.Location = new System.Drawing.Point(27, 56);
            this.lblFormatSize.Name = "lblFormatSize";
            this.lblFormatSize.Size = new System.Drawing.Size(71, 13);
            this.lblFormatSize.TabIndex = 2;
            this.lblFormatSize.Text = "- FormatSize: ";
            // 
            // lblFormatID
            // 
            this.lblFormatID.AutoSize = true;
            this.lblFormatID.Location = new System.Drawing.Point(27, 34);
            this.lblFormatID.Name = "lblFormatID";
            this.lblFormatID.Size = new System.Drawing.Size(62, 13);
            this.lblFormatID.TabIndex = 1;
            this.lblFormatID.Text = "- FormatID: ";
            // 
            // lblFmtChunk
            // 
            this.lblFmtChunk.AutoSize = true;
            this.lblFmtChunk.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFmtChunk.Location = new System.Drawing.Point(7, 16);
            this.lblFmtChunk.Name = "lblFmtChunk";
            this.lblFmtChunk.Size = new System.Drawing.Size(116, 14);
            this.lblFmtChunk.TabIndex = 0;
            this.lblFmtChunk.Text = "* The Format Chunk";
            this.lblFmtChunk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCommand
            // 
            this.grpCommand.Controls.Add(this.btnDetect);
            this.grpCommand.Controls.Add(this.btnEnegryGraph);
            this.grpCommand.Controls.Add(this.btnSignalGraph);
            this.grpCommand.Location = new System.Drawing.Point(13, 344);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Size = new System.Drawing.Size(443, 63);
            this.grpCommand.TabIndex = 2;
            this.grpCommand.TabStop = false;
            this.grpCommand.Text = "Command";
            // 
            // btnDetect
            // 
            this.btnDetect.Enabled = false;
            this.btnDetect.Location = new System.Drawing.Point(308, 23);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(118, 23);
            this.btnDetect.TabIndex = 1;
            this.btnDetect.Text = "Detect";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // btnEnegryGraph
            // 
            this.btnEnegryGraph.Enabled = false;
            this.btnEnegryGraph.Location = new System.Drawing.Point(168, 23);
            this.btnEnegryGraph.Name = "btnEnegryGraph";
            this.btnEnegryGraph.Size = new System.Drawing.Size(118, 23);
            this.btnEnegryGraph.TabIndex = 1;
            this.btnEnegryGraph.Text = "Show Enegry Graph";
            this.btnEnegryGraph.UseVisualStyleBackColor = true;
            this.btnEnegryGraph.Click += new System.EventHandler(this.btnEnegryGraph_Click);
            // 
            // btnSignalGraph
            // 
            this.btnSignalGraph.Enabled = false;
            this.btnSignalGraph.Location = new System.Drawing.Point(27, 23);
            this.btnSignalGraph.Name = "btnSignalGraph";
            this.btnSignalGraph.Size = new System.Drawing.Size(118, 23);
            this.btnSignalGraph.TabIndex = 0;
            this.btnSignalGraph.Text = "Show Signal Graph";
            this.btnSignalGraph.UseVisualStyleBackColor = true;
            this.btnSignalGraph.Click += new System.EventHandler(this.btnSignalGraph_Click);
            // 
            // grpOption
            // 
            this.grpOption.Controls.Add(this.label4);
            this.grpOption.Controls.Add(this.label3);
            this.grpOption.Controls.Add(this.txtActivity);
            this.grpOption.Controls.Add(this.txtQuite);
            this.grpOption.Controls.Add(this.label2);
            this.grpOption.Controls.Add(this.txtCoveredWide);
            this.grpOption.Controls.Add(this.label1);
            this.grpOption.Controls.Add(this.txtWindowWide);
            this.grpOption.Controls.Add(this.btnSave);
            this.grpOption.Location = new System.Drawing.Point(13, 412);
            this.grpOption.Name = "grpOption";
            this.grpOption.Size = new System.Drawing.Size(443, 173);
            this.grpOption.TabIndex = 3;
            this.grpOption.TabStop = false;
            this.grpOption.Text = "Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quite";
            // 
            // txtQuite
            // 
            this.txtQuite.Location = new System.Drawing.Point(104, 81);
            this.txtQuite.Name = "txtQuite";
            this.txtQuite.Size = new System.Drawing.Size(159, 20);
            this.txtQuite.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Covered Wide";
            // 
            // txtCoveredWide
            // 
            this.txtCoveredWide.Location = new System.Drawing.Point(104, 55);
            this.txtCoveredWide.Name = "txtCoveredWide";
            this.txtCoveredWide.Size = new System.Drawing.Size(159, 20);
            this.txtCoveredWide.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Window Wide";
            // 
            // txtWindowWide
            // 
            this.txtWindowWide.Location = new System.Drawing.Point(104, 28);
            this.txtWindowWide.Name = "txtWindowWide";
            this.txtWindowWide.Size = new System.Drawing.Size(159, 20);
            this.txtWindowWide.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(247, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtActivity
            // 
            this.txtActivity.Location = new System.Drawing.Point(104, 107);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(159, 20);
            this.txtActivity.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Activity";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 596);
            this.Controls.Add(this.grpOption);
            this.Controls.Add(this.grpCommand);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpCommand.ResumeLayout(false);
            this.grpOption.ResumeLayout(false);
            this.grpOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.GroupBox grpCommand;
        private System.Windows.Forms.Button btnSignalGraph;
        private System.Windows.Forms.Button btnEnegryGraph;
        private System.Windows.Forms.GroupBox grpOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCoveredWide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWindowWide;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuite;
        private System.Windows.Forms.Label lblFmtChunk;
        private System.Windows.Forms.Label lblFormatID;
        private System.Windows.Forms.Label lblFormatSize;
        private System.Windows.Forms.Label lblAudioFormat;
        private System.Windows.Forms.Label lblNumChannels;
        private System.Windows.Forms.Label lblSampleRate;
        private System.Windows.Forms.Label lblByteRate;
        private System.Windows.Forms.Label lblBlockAlign;
        private System.Windows.Forms.Label lblBitsPerSample;
        private System.Windows.Forms.Label lblDataChunk;
        private System.Windows.Forms.Label lblDataID;
        private System.Windows.Forms.Label lblDataSize;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label txtFormatID;
        private System.Windows.Forms.Label txtFormatSize;
        private System.Windows.Forms.Label txtAudioFormat;
        private System.Windows.Forms.Label txtNumberChannels;
        private System.Windows.Forms.Label txtSampleRate;
        private System.Windows.Forms.Label txtByteRate;
        private System.Windows.Forms.Label txtBlockAlign;
        private System.Windows.Forms.Label txtBitsPerSample;
        private System.Windows.Forms.Label txtDataID;
        private System.Windows.Forms.Label txtDataSize;
        private System.Windows.Forms.Label txtData;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtActivity;
    }
}