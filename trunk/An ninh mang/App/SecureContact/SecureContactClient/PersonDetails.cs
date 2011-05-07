using System;
using System.Windows.Forms;
using SecureContactClient.ContactService;

namespace SecureContactClient
{
    public partial class PersonDetails : Form
    {
        private Person person;

        private PersonDetails()
        {
            InitializeComponent();
        }

        public PersonDetails(Person person)
            : this()
        {
            this.person = person;
        }

        public void BindData(Person person)
        {
            if (person == null)
            {
                throw new Exception("person cannot be null");
            }

            personBindingSource.DataSource = person;
        }

        private void PersonDetails_Load(object sender, EventArgs e)
        {
            BindData(this.person);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //ContactService.ContactServiceClient client = new ContactServiceClient();

            try
            {
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
