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
using HCMSApplication.Forms;

namespace HCMSApplication
{
    public partial class BrowseDepartmentsForm : Form
    {
        private User CurrentUser;
        private Form PreviousForm;
        private IList<Department> AllDepartments;
        public void setCurrentUser(User user)
        {
            this.CurrentUser = user;
        }
        public void setPreviousForm(Form form)
        {
            this.PreviousForm = form;
        }
        public BrowseDepartmentsForm(User user,Form form)
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.DepartmentsListBox.Items.Clear();
            this.NameTextBox.Text = "";
            this.SearchButton_Click(sender, e);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                ICriteria cr = session.CreateCriteria(typeof(Department));
                if (this.NameTextBox.Text.Trim() != "")
                {
                    cr.Add(Restrictions.Eq("DepartmentName", this.NameTextBox.Text.Trim()));
                }
                this.AllDepartments = cr.List<Department>();
            }
            session.Close();
            this.DepartmentsListBox.Items.Clear();
            foreach (Department department in this.AllDepartments)
            {
                this.DepartmentsListBox.Items.Add(department.ToString());
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(this.DepartmentsListBox.SelectedIndex != -1)
            {
                EditDepartment editDepartment = new EditDepartment(this.CurrentUser, this, this.AllDepartments[this.DepartmentsListBox.SelectedIndex]);
                this.Hide();
                editDepartment.Show();
            }
            else
            {
                MessageBox.Show("Please select department to Edit");
            }
        }

        private void NewDepartment_Click(object sender, EventArgs e)
        {
            NewDepartment NewDepartmentForm = new HCMSApplication.Forms.NewDepartment(this.CurrentUser, this);
            NewDepartmentForm.Show();
            this.Hide();
        }

        private void BrowseDepartmentsForm_Load(object sender, EventArgs e)
        {
            if(this.CurrentUser.Admin)
            {
                this.DeleteDepartmentButton.Enabled = true;
            }
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                var departments = session
                    .CreateCriteria(typeof(Department))
                    .List<Department>();
                this.AllDepartments = departments;
            }
            session.Close();
            foreach (Department department in this.AllDepartments)
            {
                this.DepartmentsListBox.Items.Add(department.ToString());
            }
        }

        private void DeleteDepartmentButton_Click(object sender, EventArgs e)
        {
            if (this.DepartmentsListBox.SelectedIndex != -1)
            {
                ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                ISession session = sessionFactory.OpenSession();
                using (ITransaction transaction = session.BeginTransaction())
                {
                    IList<Position> positions = session
                        .CreateCriteria(typeof(Position))
                        .Add(Restrictions.Eq("DepartmentID", this.AllDepartments[this.DepartmentsListBox.SelectedIndex].ID))
                        .List<Position>();
                    foreach(Position position in positions)
                    {
                        IList<Employee> employees = session
                        .CreateCriteria(typeof(Employee))
                        .Add(Restrictions.Eq("Position_ID", position.ID))
                        .List<Employee>();
                        foreach(Employee employee in employees)
                        {
                            var leavebalance = session
                                .CreateCriteria(typeof(LeaveBalance))
                                .Add(Restrictions.Eq("EmployeeID", employee.ID))
                                .UniqueResult<LeaveBalance>();
                            IList<LeaveRequest> requests = session
                                .CreateCriteria(typeof(LeaveRequest))
                                .Add(Restrictions.Eq("EmployeeID", employee.ID))
                                .List<LeaveRequest>();
                            session.Delete(leavebalance);
                            foreach (LeaveRequest request in requests)
                            {
                                session.Delete(request);
                            }
                            session.Delete(employee);
                        }
                        session.Delete(position);
                    }
                    session.Delete(this.AllDepartments[this.DepartmentsListBox.SelectedIndex]);
                    transaction.Commit();
                }
                session.Close();
                this.ClearButton_Click(sender, e);
                this.SearchButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select department to delete");
            }
        }
    }
}
