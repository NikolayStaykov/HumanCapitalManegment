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
    public partial class MainMenuForm : Form
    {
        private User CurrrentUser;
        public void setCurrentUser(User user)
        {
            this.CurrrentUser = user;
        }
        public MainMenuForm(User user)
        {
            InitializeComponent();
            this.CurrrentUser = user;
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            if(this.CurrrentUser.Admin == true)
            {
                this.UsersButton.Enabled = true;
            }
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            BrowseEmployeesForm browseEmployees = new BrowseEmployeesForm(this.CurrrentUser, this);
            browseEmployees.Show();
            this.Hide();
        }

        private void DepartmentsButton_Click(object sender, EventArgs e)
        {
            BrowseDepartmentsForm BrowseDepartments = new BrowseDepartmentsForm(this.CurrrentUser, this);
            BrowseDepartments.Show();
            this.Hide();
        }

        private void LeaveRequestsButton_Click(object sender, EventArgs e)
        {
            BrowseLeaveRequestsForm BrowseLeaveRequests = new BrowseLeaveRequestsForm(this.CurrrentUser, this);
            BrowseLeaveRequests.Show();
            this.Hide();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            BrowseUsersForm BrowseUsers = new BrowseUsersForm(this.CurrrentUser, this);
            BrowseUsers.Show();
            this.Hide();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(this.CurrrentUser,this);
            this.Hide();
            changePassword.Show();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
