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
    public partial class EditEmployee : Form
    {
        private User CurrentUser;
        private Form PreviousForm;
        private Employee EmployeeToEdit;
        private LeaveBalance LeaveBalanceToEdit;
        private IList<Department> AllDepartments;
        private IList<Position> AllPositions;
        public EditEmployee(User user, Form form, Employee employee)
        {
            InitializeComponent();
            this.CurrentUser = user;
            this.PreviousForm = form;
            this.EmployeeToEdit = employee;
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                var balance = session
                    .CreateCriteria(typeof(LeaveBalance))
                    .Add(Restrictions.Eq("EmployeeID", this.EmployeeToEdit.ID))
                    .UniqueResult<LeaveBalance>();
                this.LeaveBalanceToEdit = balance;
                var departments = session
                    .CreateCriteria(typeof(Department))
                    .List<Department>();
                this.AllDepartments = departments;
            }
            session.Close();
            foreach(Department department in this.AllDepartments)
            {
                this.DepartmentComboBox.Items.Add(department.DepartmentName);
            }
            this.EmploymentStatusComboBox.SelectedItem = EmployeeToEdit.EmploymentStatus;
            this.EmployeeIDTextBox.Text = this.EmployeeToEdit.ID.ToString();
            this.NameTextBox.Text = this.EmployeeToEdit.Name;
            this.EmailTextBox.Text = this.EmployeeToEdit.Email;
            this.PhoneTextBox.Text = this.EmployeeToEdit.Phone;
            this.AddressTextBox.Text = this.EmployeeToEdit.Address;
            this.SalaryTextBox.Text = this.EmployeeToEdit.Salary;
            this.EmergencyContactTextBox.Text = this.EmployeeToEdit.EmergencyContact;
            this.MaternalLeaveTextBox.Text = this.LeaveBalanceToEdit.MaternalLeave.ToString();
            this.PaidLeaveTextBox.Text = this.LeaveBalanceToEdit.AnnualPaidLeave.ToString();
            this.UnpaidLeaveTextBox.Text = this.LeaveBalanceToEdit.AnnualUnpaidLeave.ToString();
            this.SickLeaveTextBox.Text = this.LeaveBalanceToEdit.SickLeave.ToString();
            this.HolidayLeaveTextBox.Text = this.LeaveBalanceToEdit.HolidayLeave.ToString();
            if(this.CurrentUser.Admin)
            {
                this.PaidLeaveTextBox.ReadOnly = false;
                this.UnpaidLeaveTextBox.ReadOnly = false;
                this.SickLeaveTextBox.ReadOnly = false;
                this.MaternalLeaveTextBox.ReadOnly = false;
                this.HolidayLeaveTextBox.ReadOnly = false;
            }
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
                this.AllPositions = positions;
            }
            session.Close();
            foreach (Position position in this.AllPositions)
            {
                this.PositionComboBox.Items.Add(position.Name);
            }
            this.PositionComboBox.SelectedIndex = -1;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.EmployeeToEdit.Name = this.NameTextBox.Text.Trim();
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            this.EmployeeToEdit.Email = this.EmailTextBox.Text.Trim();
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            this.EmployeeToEdit.Phone = this.PhoneTextBox.Text.Trim();
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            this.EmployeeToEdit.Address = this.AddressTextBox.Text.Trim();
        }

        private void SalaryTextBox_TextChanged(object sender, EventArgs e)
        {
            this.EmployeeToEdit.Salary = this.SalaryTextBox.Text.Trim();
        }

        private void EmergencyContactTextBox_TextChanged(object sender, EventArgs e)
        {
            this.EmployeeToEdit.EmergencyContact = this.EmergencyContactTextBox.Text.Trim();
        }

        private void PositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PositionComboBox.SelectedIndex != -1)
            {
                this.EmployeeToEdit.Position_ID = this.AllPositions[PositionComboBox.SelectedIndex].ID;
            }
        }

        private void PaidLeaveTextBox_TextChanged(object sender, EventArgs e)
        {
            this.LeaveBalanceToEdit.AnnualPaidLeave = Int32.Parse(PaidLeaveTextBox.Text.Trim());
        }

        private void UnpaidLeaveTextBox_TextChanged(object sender, EventArgs e)
        {
            this.LeaveBalanceToEdit.AnnualUnpaidLeave = Int32.Parse(UnpaidLeaveTextBox.Text.Trim());
        }

        private void SickLeaveTextBox_TextChanged(object sender, EventArgs e)
        {
            this.LeaveBalanceToEdit.SickLeave = Int32.Parse(SickLeaveTextBox.Text.Trim());
        }

        private void MaternalLeaveTextBox_TextChanged(object sender, EventArgs e)
        {
            this.LeaveBalanceToEdit.MaternalLeave = Int32.Parse(MaternalLeaveTextBox.Text.Trim());
        }

        private void HolidayLeaveTextBox_TextChanged(object sender, EventArgs e)
        {
            this.LeaveBalanceToEdit.HolidayLeave = Int32.Parse(HolidayLeaveTextBox.Text.Trim());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.PreviousForm.Show();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(this.EmployeeToEdit);
                session.Update(this.LeaveBalanceToEdit);
                transaction.Commit();
            }
            session.Close();
            MessageBox.Show("Employee Updated Sucessfully");
        }

        private void NewLeaveRequest_Click(object sender, EventArgs e)
        {
            Form NewLeaveRequestForm = new HCMSApplication.Forms.Creation_Forms.NewLeaveRequest(this.CurrentUser, this, this.EmployeeToEdit.ID);
            NewLeaveRequestForm.Show();
            this.Hide();
        }
    }
}
