using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCMSApplication
{
    public partial class BrowseEmployeesForm : Form
    {
        private User CurrentUser;
        private Form PreviousForm;
        public void setCurrentUser(User user)
        {
            this.CurrentUser = user;
        }
        public void setPreviousForm(Form form)
        {
            this.PreviousForm = form;
        }
        public BrowseEmployeesForm(User user,Form form)
        {
            InitializeComponent();
            this.CurrentUser = user;
            this.PreviousForm = form;
        }

        private void BrowseEmployeesForm_Load(object sender, EventArgs e)
        {
            if(this.CurrentUser.getAdmin())
            {
                
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PreviousForm.Show();
        }
    }
}
