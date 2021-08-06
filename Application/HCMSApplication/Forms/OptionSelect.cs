using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCMSApplication.Forms
{
    public partial class Main_Menu : Form
    {
        private User CurrentUser;

        public void setCurrentUser(User user)
        {
            this.CurrentUser = user;
        }
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            BrowseEmployees EmployeesForm = new BrowseEmployees();
            EmployeesForm.setPreviousForm(this);
            EmployeesForm.setCurrentUser(this.CurrentUser);
            EmployeesForm.Show();
            this.Hide();
        }

        private void DepartmentsButton_Click(object sender, EventArgs e)
        {
            BrowseDepartments DepartmentsForm = new BrowseDepartments();
            DepartmentsForm.setCurrentUser(this.CurrentUser);
            DepartmentsForm.setPreviousForm(this);
            DepartmentsForm.Show();
            this.Hide();
        }

        private void LeaveRequests_Click(object sender, EventArgs e)
        {
            BrowseLeaveRequests LeaveRequestsForm = new BrowseLeaveRequests();
            LeaveRequestsForm.setCurrentUser(CurrentUser);
            LeaveRequestsForm.setPreviousForm(this);
            LeaveRequests.Show();
            this.Hide();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            BrowseUsers UsersForm = new BrowseUsers();
            UsersForm.setCurrentUser(CurrentUser);
            UsersForm.setPreviousForm(this);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            CurrentUser = new User(0, "admin", "admin", true);
            if (CurrentUser.getAdmin())
            {
                this.UsersButton.Visible = true;
            }
        }
    }
}
