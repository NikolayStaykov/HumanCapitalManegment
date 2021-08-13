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
    public partial class BrowseEmployeesForm : Form
    {
        private User CurrentUser;
        private Form PreviousForm;
        private IList<Employee> AllEmployees;
        private IList<Department> AllDepartments;
        private IList<Position> Positions;
        public BrowseEmployeesForm(User user,Form form)
        {
            InitializeComponent();
            this.CurrentUser = user;
            this.PreviousForm = form;
        }

        private void BrowseEmployeesForm_Load(object sender, EventArgs e)
        {
            if(this.CurrentUser.Admin)
            {
                this.DeleteEmployeeButton.Enabled = true;
            }
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                var employees = session
                    .CreateCriteria(typeof(Employee))
                    .List<Employee>();
                this.AllEmployees = employees;
                var departments = session
                    .CreateCriteria(typeof(Department))
                    .List<Department>();
                this.AllDepartments = departments;
            }
            session.Close();
            foreach (Employee employee in this.AllEmployees)
            {
                this.EmployeesListBox.Items.Add(employee.ToString());
            }
            foreach(Department department in this.AllDepartments)
            {
                this.DepartmentComboBox.Items.Add(department.DepartmentName);
            }
            this.DepartmentComboBox.SelectedIndex = -1;
            this.PositionComboBox.SelectedIndex = -1;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PreviousForm.Show();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.AddressTextBox.Text = "";
            this.EmailTextBox.Text = "";
            this.NameTextBox.Text = "";
            this.PhoneTextBox.Text = "";
            this.EmployeeIDTextBox.Text = "";
            this.SalaryTextBox.Text = "";
            this.PositionComboBox.SelectedIndex = -1;
            this.DepartmentComboBox.SelectedIndex = -1;
            this.EmployeesListBox.Items.Clear();
            this.PositionComboBox.Items.Clear();
        }

        private void DepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DepartmentComboBox.SelectedIndex != -1)
            {
                PositionComboBox.Items.Clear();
                Department Current;
                ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                ISession session = sessionFactory.OpenSession();
                using (session.BeginTransaction())
                {
                    var department = session
                        .CreateCriteria(typeof(Department))
                        .Add(Restrictions.Eq("DepartmentName", this.DepartmentComboBox.SelectedItem.ToString()))
                        .UniqueResult<Department>();
                    Current = department;
                    var positions = session
                        .CreateCriteria(typeof(Position))
                        .Add(Restrictions.Eq("DepartmentID", Current.ID))
                        .List<Position>();
                    this.Positions = positions;
                }
                session.Close();
                foreach (Position position in this.Positions)
                {
                    this.PositionComboBox.Items.Add(position.Name);
                }
                this.PositionComboBox.SelectedIndex = -1;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                ICriteria cr = session.CreateCriteria(typeof(Employee));
                if (this.NameTextBox.Text.Trim() != "")
                {
                    cr.Add(Restrictions.Eq("Name", this.NameTextBox.Text.Trim()));
                }
                if(this.EmployeeIDTextBox.Text.Trim() != "")
                {
                    int id = Int32.Parse(this.EmployeeIDTextBox.Text.Trim());
                    cr.Add(Restrictions.Eq("ID",id));
                }
                if(this.AddressTextBox.Text.Trim() != "")
                {
                    cr.Add(Restrictions.Eq("Address", this.AddressTextBox.Text.Trim())); ;
                }
                if(this.EmailTextBox.Text.Trim() != "")
                {
                    cr.Add(Restrictions.Eq("Email", this.EmailTextBox.Text.Trim()));
                }
                if (this.PhoneTextBox.Text.Trim() != "")
                {
                    cr.Add(Restrictions.Eq("Phone", this.PhoneTextBox.Text.Trim()));
                }
                if (this.SalaryTextBox.Text.Trim() != "")
                {
                    cr.Add(Restrictions.Eq("Salary", this.SalaryTextBox.Text.Trim()));
                }
                if (this.PositionComboBox.SelectedIndex != -1)
                {
                    cr.Add(Restrictions.Eq("Position_ID", this.Positions[this.PositionComboBox.SelectedIndex].ID));
                }
                if (this.EmploymentStatusComboBox.SelectedIndex != -1)
                {
                    cr.Add(Restrictions.Eq("EmploymentStatus", this.EmploymentStatusComboBox.SelectedItem.ToString()));
                }
                this.AllEmployees = cr.List<Employee>();
            }
            session.Close();
            this.EmployeesListBox.Items.Clear();
            foreach (Employee employee in this.AllEmployees)
            {
                this.EmployeesListBox.Items.Add(employee.ToString());
            }
        }

        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            Form NewEmployeeForm = new HCMSApplication.Forms.NewEmployee(this.CurrentUser, this);
            NewEmployeeForm.Show();
            this.Hide();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (this.EmployeesListBox.SelectedIndex != -1)
            {
                Form EditEmployeeForm = new HCMSApplication.Forms.EditEmployee(this.CurrentUser, this, this.AllEmployees[EmployeesListBox.SelectedIndex]);
                EditEmployeeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select employee to edit");
            }
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (this.EmployeesListBox.SelectedIndex != -1)
            {
                ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                ISession session = sessionFactory.OpenSession();
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var leavebalance = session
                        .CreateCriteria(typeof(LeaveBalance))
                        .Add(Restrictions.Eq("EmployeeID", this.AllEmployees[this.EmployeesListBox.SelectedIndex].ID))
                        .UniqueResult<LeaveBalance>();
                    IList<LeaveRequest> requests = session
                        .CreateCriteria(typeof(LeaveRequest))
                        .Add(Restrictions.Eq("EmployeeID", this.AllEmployees[this.EmployeesListBox.SelectedIndex].ID))
                        .List<LeaveRequest>();
                    session.Delete(leavebalance);
                    foreach(LeaveRequest request in requests)
                    {
                        session.Delete(request);
                    }
                    session.Delete(this.AllEmployees[this.EmployeesListBox.SelectedIndex]);
                    transaction.Commit();
                }
                session.Close();
                this.ClearButton_Click(sender, e);
                this.SearchButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select employee to delete");
            }
        }
    }
}
