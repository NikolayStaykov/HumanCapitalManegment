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
    public partial class EditDepartment : Form
    {
        private User CurrentUser;
        private Form PreviousForm;
        private Department DepartmentToEdit;
        private IList<Position> AllPositions;
        public EditDepartment(User user,Form form, Department department)
        {
            InitializeComponent();
            this.CurrentUser = user;
            this.PreviousForm = form;
            this.DepartmentToEdit = department;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.PreviousForm.Show();
        }

        private void EditDepartment_Load(object sender, EventArgs e)
        {
            if(this.CurrentUser.Admin)
            {
                this.DeletePositionButton.Enabled = true;
            }    
            this.DepartmentIDTextBox.Text = this.DepartmentToEdit.ID.ToString();
            this.NameTextBox.Text = this.DepartmentToEdit.DepartmentName;
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                var positions = session
                    .CreateCriteria(typeof(Position))
                    .Add(Restrictions.Eq("DepartmentID",this.DepartmentToEdit.ID))
                    .List<Position>();
                this.AllPositions = positions;
            }
            session.Close();
            foreach (Position position in this.AllPositions)
            {
                this.PositionsListBox.Items.Add(position.ToString());
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(this.DepartmentToEdit);
                transaction.Commit();
            }
            session.Close();
            MessageBox.Show("Changes Saved Successfully");
            this.Hide();
            this.PreviousForm.Show();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.DepartmentToEdit.DepartmentName = this.NameTextBox.Text;
        }

        private void NewPositionButton_Click(object sender, EventArgs e)
        {
            NewPosition newPosition = new NewPosition(this.CurrentUser, this, this.DepartmentToEdit.ID);
            newPosition.Show();
            this.Hide();
        }

        private void EditPositionButton_Click(object sender, EventArgs e)
        {
            if (PositionsListBox.SelectedIndex != -1)
            {
                EditPosition editPosition = new EditPosition(this.CurrentUser, this, this.AllPositions[PositionsListBox.SelectedIndex]);
                editPosition.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Select A position to Edit");
            }
        }

        private void DeletePositionButton_Click(object sender, EventArgs e)
        {
            if (this.PositionsListBox.SelectedIndex != -1)
            {
                ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                ISession session = sessionFactory.OpenSession();
                using (ITransaction transaction = session.BeginTransaction())
                {
                    IList<Employee> employees = session
                        .CreateCriteria(typeof(Employee))
                        .Add(Restrictions.Eq("Position_ID", this.AllPositions[this.PositionsListBox.SelectedIndex].ID))
                        .List<Employee>();
                    foreach (Employee employee in employees)
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
                    session.Delete(this.AllPositions[this.PositionsListBox.SelectedIndex]);
                    transaction.Commit();
                }
                session.Close();
            }
            else
            {
                MessageBox.Show("Please select Position to delete");
            }
        }
    }
}
