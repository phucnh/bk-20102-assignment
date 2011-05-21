namespace SecureContactClient
{
    using System;
    using System.Windows.Forms;

    using SecureContactService;

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void buttonGetInformation_Click(object sender, EventArgs e)
        {
            var client = new ContactServiceClient();
            try
            {
                Person p = client.GetPerson(Convert.ToInt32(this.textBoxID.Text));
                this.dataGrid.DataSource = new[] { p };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            var client = new ContactServiceClient();
            this.dataGrid.DataSource = client.GetAll();
        }
    }
}