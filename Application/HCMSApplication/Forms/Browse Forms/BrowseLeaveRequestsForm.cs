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
    public partial class BrowseLeaveRequestsForm : Form
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
        public BrowseLeaveRequestsForm(User user, Form form)
        {
            InitializeComponent();
            this.CurrentUser = user;
            this.PreviousForm = form;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.Show();
            this.Hide();
        }
    }
}
