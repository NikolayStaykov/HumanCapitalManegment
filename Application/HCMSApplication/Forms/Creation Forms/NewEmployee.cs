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

namespace HCMSApplication.Forms
{
    public partial class NewEmployee : Form
    {
        private User CurrentUser;
        private Form PreviousForm;
        private IList<Department> Departments;
        private IList<Position> Positions;
        public NewEmployee(User user,Form form)
        {
            InitializeComponent();
            this.CurrentUser = user;
            this.PreviousForm = form;
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                var departments = session
                    .CreateCriteria(typeof(Department))
                    .List<Department>();
                this.Departments = departments;
            }
            session.Close();
            foreach (Department department in this.Departments)
            {
                this.DepartmentComboBox.Items.Add(department.DepartmentName);
            }
            this.DepartmentComboBox.SelectedIndex = -1;
            this.PositionComboBox.SelectedIndex = -1;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.PreviousForm.Show();
        }

        private void DepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void SaveEmployeeButton_Click(object sender, EventArgs e)
        {
            if (this.NameTextBox.Text.Trim() != "" && this.AddressTextBox.Text.Trim() != "" && this.EmailTextBox.Text.Trim() != "" && this.PhoneTextBox.Text.Trim() != "" && this.SalaryTextBox.Text.Trim() != "" && this.EmergencyContactTextBox.Text.Trim() != "" && this.PaidLeaveTextBox.Text.Trim() != "" && this.UnpaidLeaveTextBox.Text.Trim() != "" && this.MaternalLeaveTextBox.Text.Trim() != "" && this.SickLeaveTextBox.Text.Trim() != "" && this.HolidayLeaveTextBox.Text.Trim() != "")
            {
                if (this.PositionComboBox.SelectedIndex != -1 && this.EmploymentStatusComboBox.SelectedIndex != -1)
                {
                    Employee NewEmployee = new Employee(0, this.NameTextBox.Text.Trim(), this.AddressTextBox.Text.Trim(), this.EmailTextBox.Text.Trim(), this.PhoneTextBox.Text.Trim(), this.EmergencyContactTextBox.Text.Trim(),this.EmploymentStatusComboBox.SelectedItem.ToString(), this.SalaryTextBox.Text.Trim(),this.Positions[this.PositionComboBox.SelectedIndex].ID);
                    
                    ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                    ISession session = sessionFactory.OpenSession();
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(NewEmployee);
                        transaction.Commit();
                    }
                    LeaveBalance NewLeaveBalance = new LeaveBalance(0, NewEmployee.ID, Int32.Parse(this.MaternalLeaveTextBox.Text.Trim()), Int32.Parse(this.PaidLeaveTextBox.Text.Trim()), Int32.Parse(this.UnpaidLeaveTextBox.Text.Trim()), Int32.Parse(this.SickLeaveTextBox.Text.Trim()), Int32.Parse(this.HolidayLeaveTextBox.Text.Trim()));
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(NewLeaveBalance);
                        transaction.Commit();
                    }
                    session.Close();
                    MessageBox.Show("Employee Saved Sucessfully.");
                }
                else
                {
                    MessageBox.Show("Please Enter Required Information");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Required Information");
            }
        }
    }
}
