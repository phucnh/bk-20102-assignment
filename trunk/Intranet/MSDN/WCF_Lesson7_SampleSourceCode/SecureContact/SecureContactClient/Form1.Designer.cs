namespace SecureContactClient
{
    using SecureContactService;

    partial class Form1
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonGetInformation = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.buttonGetAll = new System.Windows.Forms.Button();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(62, 10);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 1;
            // 
            // buttonGetInformation
            // 
            this.buttonGetInformation.Location = new System.Drawing.Point(168, 8);
            this.buttonGetInformation.Name = "buttonGetInformation";
            this.buttonGetInformation.Size = new System.Drawing.Size(97, 23);
            this.buttonGetInformation.TabIndex = 2;
            this.buttonGetInformation.Text = "Get Information";
            this.buttonGetInformation.UseVisualStyleBackColor = true;
            this.buttonGetInformation.Click += new System.EventHandler(this.buttonGetInformation_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                                                                                                 this.ID,
                                                                                                 this.FullName,
                                                                                                 this.Age});
            this.dataGrid.DataSource = this.personBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(16, 37);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(330, 251);
            this.dataGrid.TabIndex = 4;
            // 
            // buttonGetAll
            // 
            this.buttonGetAll.Location = new System.Drawing.Point(271, 8);
            this.buttonGetAll.Name = "buttonGetAll";
            this.buttonGetAll.Size = new System.Drawing.Size(75, 23);
            this.buttonGetAll.TabIndex = 3;
            this.buttonGetAll.Text = "Get All";
            this.buttonGetAll.UseVisualStyleBackColor = true;
            this.buttonGetAll.Click += new System.EventHandler(this.buttonGetAll_Click);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Person);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "PersonId";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 200;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 300);
            this.Controls.Add(this.buttonGetAll);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.buttonGetInformation);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Staff Information";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonGetInformation;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonGetAll;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
    }
}