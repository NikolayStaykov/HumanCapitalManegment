using NHibernate;
using NHibernate.Criterion;
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
        private IList<LeaveRequest> AllRequests;
        private bool StartFlag;
        private bool EndFlag;
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
            this.StartFlag = false;
            this.EndFlag = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.Show();
            this.Hide();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.EmployeeIDTextBox.Text = "";
            this.StartDateTime.Value = System.DateTime.Now;
            this.EndDateTime.Value = System.DateTime.Now;
            this.StartFlag = false;
            this.EndFlag = false;
            this.StatusComboBox.SelectedIndex = -1;
            this.TypeComboBox.SelectedIndex = -1;
            this.LeaveRequestsListBox.Items.Clear();
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                var requests = session
                    .CreateCriteria(typeof(LeaveRequest))
                    .List<LeaveRequest>();
                this.AllRequests = requests;
            }
            session.Close();
            foreach (LeaveRequest request in this.AllRequests)
            {
                this.LeaveRequestsListBox.Items.Add(request.ToString());
            }
        }

        private void BrowseLeaveRequestsForm_Load(object sender, EventArgs e)
        {
            if(this.CurrentUser.Admin)
            {
                this.DeleteLeaveRequestButton.Enabled = true;
            }
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                var requests = session
                    .CreateCriteria(typeof(LeaveRequest))
                    .List<LeaveRequest>();
                this.AllRequests = requests;
            }
            session.Close();
            foreach (LeaveRequest request in this.AllRequests)
            {
                this.LeaveRequestsListBox.Items.Add(request.ToString());
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.LeaveRequestsListBox.Items.Clear();
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                ICriteria cr = session.CreateCriteria(typeof(LeaveRequest));
                if (this.EmployeeIDTextBox.Text.Trim() != "")
                {
                    cr.Add(Restrictions.Eq("EmployeeID", Int32.Parse(this.EmployeeIDTextBox.Text.Trim())));
                }
                if (this.StartFlag == true)
                {
                    cr.Add(Restrictions.Eq("Start", this.StartDateTime.Value));
                }
                if (this.EndFlag == true)
                {
                    cr.Add(Restrictions.Eq("End", this.EndDateTime.Value));
                }
                if (this.StatusComboBox.SelectedIndex != -1)
                {
                    cr.Add(Restrictions.Eq("ApproovalStatus", this.StatusComboBox.SelectedItem.ToString()));
                }
                if (this.TypeComboBox.SelectedIndex != -1)
                {
                    cr.Add(Restrictions.Eq("LeaveType", this.TypeComboBox.SelectedItem.ToString()));
                }
                this.AllRequests = cr.List<LeaveRequest>();
            }
            session.Close();
            foreach (LeaveRequest request in this.AllRequests)
            {
                this.LeaveRequestsListBox.Items.Add(request.ToString());
            }
        }

        private void StartDateTime_ValueChanged(object sender, EventArgs e)
        {
            this.StartFlag = true;
        }

        private void EndDateTime_ValueChanged(object sender, EventArgs e)
        {
            this.EndFlag = true;
        }

        private void NewLeaveRequestButton_Click(object sender, EventArgs e)
        {
            if (EmployeeIDTextBox.Text.Trim() != "")
            {
                Form NewLeaveRequestForm = new HCMSApplication.Forms.Creation_Forms.NewLeaveRequest(this.CurrentUser,this,Int32.Parse(EmployeeIDTextBox.Text.Trim()));
                NewLeaveRequestForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter an employeeID to enter a new leave request");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(LeaveRequestsListBox.SelectedIndex != -1)
            {
                Form EditLeaveRequestForm = new HCMSApplication.Forms.Edit_Forms.EditLeaveRequest(CurrentUser, this, this.AllRequests[this.LeaveRequestsListBox.SelectedIndex]);
                EditLeaveRequestForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a leave request to edit");
            }
        }

        private void DeleteLeaveRequestButton_Click(object sender, EventArgs e)
        {
            if (this.LeaveRequestsListBox.SelectedIndex != -1)
            {
                ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                ISession session = sessionFactory.OpenSession();
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(this.AllRequests[this.LeaveRequestsListBox.SelectedIndex]);
                    transaction.Commit();
                }
                session.Close();
                this.ClearButton_Click(sender, e);
                this.SearchButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select leave request to delete");
            }
        }
    }
}
