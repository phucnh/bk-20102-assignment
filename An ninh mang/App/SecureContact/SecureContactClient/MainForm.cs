using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecureContactClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            ContactService.ContactServiceClient client = new ContactService.ContactServiceClient();

            client.ClientCredentials.UserName.UserName = "admin";
            client.ClientCredentials.UserName.Password = "admin";

            try
            {
                grdAllContact.DataSource = client.GetAll();
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //client.Close();
            }
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            ContactService.ContactServiceClient client = new ContactService.ContactServiceClient();
            client.ClientCredentials.UserName.UserName = "admin";
            client.ClientCredentials.UserName.Password = "admin";

            try
            {
                ContactService.Person person = client.GetPerson(Convert.ToInt32(txtPersonId.Text));
                client.Close();

                if (person != null)
                {
                    PersonDetails frm = new PersonDetails(person);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
