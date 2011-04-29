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
            this.grpCommand = new System.Windows.Forms.GroupBox();
            this.btnEnegryGraph = new System.Windows.Forms.Button();
            this.btnSignalGraph = new System.Windows.Forms.Button();
            this.grpOption = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtWindowWide = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoveredWide = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuite = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(356, 24);
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
            this.grpDetails.Location = new System.Drawing.Point(13, 38);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(331, 355);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "File Details";
            // 
            // grpCommand
            // 
            this.grpCommand.Controls.Add(this.btnEnegryGraph);
            this.grpCommand.Controls.Add(this.btnSignalGraph);
            this.grpCommand.Location = new System.Drawing.Point(13, 399);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Size = new System.Drawing.Size(331, 63);
            this.grpCommand.TabIndex = 2;
            this.grpCommand.TabStop = false;
            this.grpCommand.Text = "Command";
            // 
            // btnEnegryGraph
            // 
            this.btnEnegryGraph.Enabled = false;
            this.btnEnegryGraph.Location = new System.Drawing.Point(182, 19);
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
            this.btnSignalGraph.Location = new System.Drawing.Point(27, 19);
            this.btnSignalGraph.Name = "btnSignalGraph";
            this.btnSignalGraph.Size = new System.Drawing.Size(118, 23);
            this.btnSignalGraph.TabIndex = 0;
            this.btnSignalGraph.Text = "Show Signal Graph";
            this.btnSignalGraph.UseVisualStyleBackColor = true;
            this.btnSignalGraph.Click += new System.EventHandler(this.btnSignalGraph_Click);
            // 
            // grpOption
            // 
            this.grpOption.Controls.Add(this.label3);
            this.grpOption.Controls.Add(this.txtQuite);
            this.grpOption.Controls.Add(this.label2);
            this.grpOption.Controls.Add(this.txtCoveredWide);
            this.grpOption.Controls.Add(this.label1);
            this.grpOption.Controls.Add(this.txtWindowWide);
            this.grpOption.Controls.Add(this.btnSave);
            this.grpOption.Location = new System.Drawing.Point(13, 482);
            this.grpOption.Name = "grpOption";
            this.grpOption.Size = new System.Drawing.Size(331, 145);
            this.grpOption.TabIndex = 3;
            this.grpOption.TabStop = false;
            this.grpOption.Text = "Options";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(250, 107);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtWindowWide
            // 
            this.txtWindowWide.Location = new System.Drawing.Point(104, 28);
            this.txtWindowWide.Name = "txtWindowWide";
            this.txtWindowWide.Size = new System.Drawing.Size(159, 20);
            this.txtWindowWide.TabIndex = 1;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 638);
            this.Controls.Add(this.grpOption);
            this.Controls.Add(this.grpCommand);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}