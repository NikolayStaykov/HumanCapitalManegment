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

namespace HCMSApplication.Forms.Creation_Forms
{
    public partial class NewLeaveRequest : Form
    {
        private User CurrentUser;
        private Form PreviousForm;
        private int EmployeeID;
        private LeaveBalance leaveBalance;

        public NewLeaveRequest(User user,Form form, int id)
        {
            InitializeComponent();
            this.CurrentUser = user;
            this.PreviousForm = form;
            this.EmployeeID = id;
        }

        private void NewLeaveRequest_Load(object sender, EventArgs e)
        {
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                var leave = session
                    .CreateCriteria(typeof(LeaveBalance))
                    .Add(Restrictions.Eq("EmployeeID", this.EmployeeID))
                    .UniqueResult<LeaveBalance>();
                this.leaveBalance = leave;
            }
            session.Close();
            this.PaidLeaveTextBox.Text = this.leaveBalance.AnnualPaidLeave.ToString();
            this.UnpaidLeaveTextBox.Text = this.leaveBalance.AnnualUnpaidLeave.ToString();
            this.SickLeaveTextBox.Text = this.leaveBalance.SickLeave.ToString();
            this.MaternalLeaveTextBox.Text = this.leaveBalance.MaternalLeave.ToString();
            this.HolidayLeaveTextBox.Text = this.leaveBalance.HolidayLeave.ToString();
            this.StatusComboBox.SelectedIndex = 1;
            this.EmployeeIDTextBox.Text = this.EmployeeID.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.PreviousForm.Show();
        }

        private void SaveLeaveRequestButton_Click(object sender, EventArgs e)
        {
            TimeSpan LeaveLength = EndDateTime.Value.Subtract(StartDateTime.Value);
            int Length = Int32.Parse(LeaveLength.Days.ToString());
            if(Length > 0)
            {
                if(TypeComboBox.SelectedIndex == 0)
                {
                    if(this.leaveBalance.MaternalLeave >= Length)
                    {
                        this.leaveBalance.MaternalLeave = this.leaveBalance.MaternalLeave - Length;
                        LeaveRequest newRequest = new LeaveRequest(0, this.EmployeeID,this.StartDateTime.Value,this.EndDateTime.Value,this.StatusComboBox.SelectedItem.ToString(),this.TypeComboBox.SelectedItem.ToString());
                        ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                        ISession session = sessionFactory.OpenSession();
                        using (ITransaction transaction = session.BeginTransaction())
                        {
                            session.Save(newRequest);
                            session.Update(this.leaveBalance);
                            transaction.Commit();
                        }
                        session.Close();
                        MessageBox.Show("Leave Request Saved Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Insucficcient Leave Balance");
                    }
                }
                else if(TypeComboBox.SelectedIndex == 1)
                {
                    if (this.leaveBalance.SickLeave >= Length)
                    {
                        this.leaveBalance.SickLeave = this.leaveBalance.SickLeave - Length;
                        LeaveRequest newRequest = new LeaveRequest(0, this.EmployeeID, this.StartDateTime.Value, this.EndDateTime.Value, this.StatusComboBox.SelectedItem.ToString(), this.TypeComboBox.SelectedItem.ToString());
                        ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                        ISession session = sessionFactory.OpenSession();
                        using (ITransaction transaction = session.BeginTransaction())
                        {
                            session.Save(newRequest);
                            session.Update(this.leaveBalance);
                            transaction.Commit();
                        }
                        session.Close();
                        MessageBox.Show("Leave Request Saved Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Insucficcient Leave Balance");
                    }
                }
                else if (TypeComboBox.SelectedIndex == 2)
                {
                    if (this.leaveBalance.AnnualPaidLeave >= Length)
                    {
                        this.leaveBalance.AnnualPaidLeave = this.leaveBalance.AnnualPaidLeave - Length;
                        LeaveRequest newRequest = new LeaveRequest(0, this.EmployeeID, this.StartDateTime.Value, this.EndDateTime.Value, this.StatusComboBox.SelectedItem.ToString(), this.TypeComboBox.SelectedItem.ToString());
                        ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                        ISession session = sessionFactory.OpenSession();
                        using (ITransaction transaction = session.BeginTransaction())
                        {
                            session.Save(newRequest);
                            session.Update(this.leaveBalance);
                            transaction.Commit();
                        }
                        session.Close();
                        MessageBox.Show("Leave Request Saved Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Insucficcient Leave Balance");
                    }
                }
                else if (TypeComboBox.SelectedIndex == 3)
                {
                    if (this.leaveBalance.AnnualUnpaidLeave >= Length)
                    {
                        this.leaveBalance.AnnualUnpaidLeave = this.leaveBalance.AnnualUnpaidLeave - Length;
                        LeaveRequest newRequest = new LeaveRequest(0, this.EmployeeID, this.StartDateTime.Value, this.EndDateTime.Value, this.StatusComboBox.SelectedItem.ToString(), this.TypeComboBox.SelectedItem.ToString());
                        ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                        ISession session = sessionFactory.OpenSession();
                        using (ITransaction transaction = session.BeginTransaction())
                        {
                            session.Save(newRequest);
                            session.Update(this.leaveBalance);
                            transaction.Commit();
                        }
                        session.Close();
                        MessageBox.Show("Leave Request Saved Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Insucficcient Leave Balance");
                    }
                }
                else if (TypeComboBox.SelectedIndex == 4)
                {
                    if (this.leaveBalance.HolidayLeave >= Length)
                    {
                        this.leaveBalance.HolidayLeave = this.leaveBalance.HolidayLeave - Length;
                        LeaveRequest newRequest = new LeaveRequest(0, this.EmployeeID, this.StartDateTime.Value, this.EndDateTime.Value, this.StatusComboBox.SelectedItem.ToString(), this.TypeComboBox.SelectedItem.ToString());
                        ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                        ISession session = sessionFactory.OpenSession();
                        using (ITransaction transaction = session.BeginTransaction())
                        {
                            session.Save(newRequest);
                            session.Update(this.leaveBalance);
                            transaction.Commit();
                        }
                        session.Close();
                        MessageBox.Show("Leave Request Saved Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Insucficcient Leave Balance");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Leave Type");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid dates");
            }
        }
    }
}
