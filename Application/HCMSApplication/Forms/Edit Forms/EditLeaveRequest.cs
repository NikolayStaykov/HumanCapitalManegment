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

namespace HCMSApplication.Forms.Edit_Forms
{
    public partial class EditLeaveRequest : Form
    {
        private User CurrentUser;
        private Form PreviousForm;
        private LeaveRequest LeaveRequestToEdit;
        private LeaveBalance leaveBalance;
        private int OriginalLeaveLength;
        public EditLeaveRequest(User user, Form form, LeaveRequest leaveRequest)
        {
            InitializeComponent();
            this.CurrentUser = user;
            this.PreviousForm = form;
            this.LeaveRequestToEdit = leaveRequest;
            TimeSpan LeaveLength = EndDateTime.Value.Subtract(StartDateTime.Value);
            this.OriginalLeaveLength = Int32.Parse(LeaveLength.Days.ToString());
        }

        private void EditLeaveRequest_Load(object sender, EventArgs e)
        {
            if(this.CurrentUser.Admin)
            {
                this.ApprooveLeave.Enabled = true;
                this.DenyLeave.Enabled = true;
            }
            this.StartDateTime.Value = this.LeaveRequestToEdit.Start;
            this.EndDateTime.Value = this.LeaveRequestToEdit.End;
            this.ApproovalStatus.Text = this.LeaveRequestToEdit.ApproovalStatus;
            this.EmployeeIDTextBox.Text = this.LeaveRequestToEdit.EmployeeID.ToString();
            this.TypeComboBox.SelectedItem = this.LeaveRequestToEdit.LeaveType;
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                var leave = session
                    .CreateCriteria(typeof(LeaveBalance))
                    .Add(Restrictions.Eq("EmployeeID", this.LeaveRequestToEdit.EmployeeID))
                    .UniqueResult<LeaveBalance>();
                this.leaveBalance = leave;
            }
            session.Close();
            this.PaidLeaveTextBox.Text = this.leaveBalance.AnnualPaidLeave.ToString();
            this.UnpaidLeaveTextBox.Text = this.leaveBalance.AnnualUnpaidLeave.ToString();
            this.SickLeaveTextBox.Text = this.leaveBalance.SickLeave.ToString();
            this.MaternalLeaveTextBox.Text = this.leaveBalance.MaternalLeave.ToString();
            this.HolidayLeaveTextBox.Text = this.leaveBalance.HolidayLeave.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.PreviousForm.Show();
        }

        private void StartDateTime_ValueChanged(object sender, EventArgs e)
        {
            this.LeaveRequestToEdit.Start = this.StartDateTime.Value;
        }

        private void EndDateTime_ValueChanged(object sender, EventArgs e)
        {
            this.LeaveRequestToEdit.End = this.EndDateTime.Value;
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            TimeSpan LeaveLength = EndDateTime.Value.Subtract(StartDateTime.Value);
            int Length = Int32.Parse(LeaveLength.Days.ToString());
            if (Length > 0)
            {
                if (TypeComboBox.SelectedIndex == 0)
                {
                    if (this.leaveBalance.MaternalLeave + this.OriginalLeaveLength >= Length)
                    {
                        this.leaveBalance.MaternalLeave = this.leaveBalance.MaternalLeave + this.OriginalLeaveLength - Length;
                        ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                        ISession session = sessionFactory.OpenSession();
                        using (ITransaction transaction = session.BeginTransaction())
                        {
                            session.Update(this.LeaveRequestToEdit);
                            session.Update(this.leaveBalance);
                            transaction.Commit();
                        }
                        session.Close();
                        MessageBox.Show("Leave Request Updated Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Insucficcient Leave Balance");
                    }
                }
                else if (TypeComboBox.SelectedIndex == 1)
                {
                    if (this.leaveBalance.SickLeave + this.OriginalLeaveLength >= Length)
                    {
                        this.leaveBalance.SickLeave = this.leaveBalance.SickLeave + this.OriginalLeaveLength - Length;
                        ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                        ISession session = sessionFactory.OpenSession();
                        using (ITransaction transaction = session.BeginTransaction())
                        {
                            session.Update(this.LeaveRequestToEdit);
                            session.Update(this.leaveBalance);
                            transaction.Commit();
                        }
                        session.Close();
                        MessageBox.Show("Leave Request Updated Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Insucficcient Leave Balance");
                    }
                }
                else if (TypeComboBox.SelectedIndex == 2)
                {
                    if (this.leaveBalance.AnnualPaidLeave + this.OriginalLeaveLength >= Length)
                    {
                        this.leaveBalance.AnnualPaidLeave = this.leaveBalance.AnnualPaidLeave + this.OriginalLeaveLength - Length;
                        ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                        ISession session = sessionFactory.OpenSession();
                        using (ITransaction transaction = session.BeginTransaction())
                        {
                            session.Update(this.LeaveRequestToEdit);
                            session.Update(this.leaveBalance);
                            transaction.Commit();
                        }
                        session.Close();
                        MessageBox.Show("Leave Request Updated Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Insucficcient Leave Balance");
                    }
                }
                else if (TypeComboBox.SelectedIndex == 3)
                {
                    if (this.leaveBalance.AnnualUnpaidLeave + this.OriginalLeaveLength >= Length)
                    {
                        this.leaveBalance.AnnualUnpaidLeave = this.leaveBalance.AnnualUnpaidLeave + this.OriginalLeaveLength - Length;
                        ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                        ISession session = sessionFactory.OpenSession();
                        using (ITransaction transaction = session.BeginTransaction())
                        {
                            session.Update(this.LeaveRequestToEdit);
                            session.Update(this.leaveBalance);
                            transaction.Commit();
                        }
                        session.Close();
                        MessageBox.Show("Leave Request Updated Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Insucficcient Leave Balance");
                    }
                }
                else if (TypeComboBox.SelectedIndex == 4)
                {
                    if (this.leaveBalance.HolidayLeave + this.OriginalLeaveLength >= Length)
                    {
                        this.leaveBalance.HolidayLeave = this.leaveBalance.HolidayLeave + this.OriginalLeaveLength - Length;
                        ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                        ISession session = sessionFactory.OpenSession();
                        using (ITransaction transaction = session.BeginTransaction())
                        {
                            session.Update(this.LeaveRequestToEdit);
                            session.Update(this.leaveBalance);
                            transaction.Commit();
                        }
                        session.Close();
                        MessageBox.Show("Leave Request Updated Sucessfully");
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

        private void ApprooveLeave_Click(object sender, EventArgs e)
        {
            this.LeaveRequestToEdit.ApproovalStatus = "Approoved";
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(this.LeaveRequestToEdit);
                transaction.Commit();
            }
            session.Close();
            MessageBox.Show("Leave Request Approoved Sucessfully");
        }

        private void DenyLeave_Click(object sender, EventArgs e)
        {
            this.LeaveRequestToEdit.ApproovalStatus = "Denied";
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(this.LeaveRequestToEdit);
                transaction.Commit();
            }
            session.Close();
            MessageBox.Show("Leave Request Approoved Sucessfully");
        }
    }
}
