namespace SecureContactClient
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
            this.grdAllContact = new System.Windows.Forms.DataGridView();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.txtPersonId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllContact)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAllContact
            // 
            this.grdAllContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllContact.Location = new System.Drawing.Point(12, 64);
            this.grdAllContact.Name = "grdAllContact";
            this.grdAllContact.Size = new System.Drawing.Size(510, 227);
            this.grdAllContact.TabIndex = 0;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(325, 12);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 1;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(211, 12);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(96, 23);
            this.btnGetInfo.TabIndex = 2;
            this.btnGetInfo.Text = "Get Information";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Location = new System.Drawing.Point(12, 16);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(49, 13);
            this.lblPersonId.TabIndex = 3;
            this.lblPersonId.Text = "PersonId";
            // 
            // txtPersonId
            // 
            this.txtPersonId.Location = new System.Drawing.Point(68, 13);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Size = new System.Drawing.Size(118, 20);
            this.txtPersonId.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 303);
            this.Controls.Add(this.txtPersonId);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.grdAllContact);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdAllContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAllContact;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.TextBox txtPersonId;
    }
}