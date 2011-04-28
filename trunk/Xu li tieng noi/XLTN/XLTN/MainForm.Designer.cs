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
            this.btnShowAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpCommand.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
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
            this.grpDetails.Size = new System.Drawing.Size(417, 249);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "File Details";
            // 
            // grpCommand
            // 
            this.grpCommand.Controls.Add(this.btnShowAll);
            this.grpCommand.Controls.Add(this.btnEnegryGraph);
            this.grpCommand.Controls.Add(this.btnSignalGraph);
            this.grpCommand.Location = new System.Drawing.Point(13, 307);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Size = new System.Drawing.Size(417, 126);
            this.grpCommand.TabIndex = 2;
            this.grpCommand.TabStop = false;
            this.grpCommand.Text = "Command";
            // 
            // btnEnegryGraph
            // 
            this.btnEnegryGraph.Enabled = false;
            this.btnEnegryGraph.Location = new System.Drawing.Point(141, 19);
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
            this.btnSignalGraph.Location = new System.Drawing.Point(6, 19);
            this.btnSignalGraph.Name = "btnSignalGraph";
            this.btnSignalGraph.Size = new System.Drawing.Size(118, 23);
            this.btnSignalGraph.TabIndex = 0;
            this.btnSignalGraph.Text = "Show Signal Graph";
            this.btnSignalGraph.UseVisualStyleBackColor = true;
            this.btnSignalGraph.Click += new System.EventHandler(this.btnSignalGraph_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Enabled = false;
            this.btnShowAll.Location = new System.Drawing.Point(278, 19);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(118, 23);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 460);
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
        private System.Windows.Forms.Button btnShowAll;
    }
}