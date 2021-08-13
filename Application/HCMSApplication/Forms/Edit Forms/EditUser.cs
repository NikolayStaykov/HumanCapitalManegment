using NHibernate;
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
    public partial class EditUser : Form
    {
        private User UserToEdit;
        private Form PreviousForm;
        private User CurrentUser;
        public EditUser(User current,User toEdit,Form form)
        {
            InitializeComponent();
            this.CurrentUser = current;
            this.UserToEdit = toEdit;
            this.PreviousForm = form;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            this.UserIDTextBox.Text = UserToEdit.ID.ToString();
            this.UserNameTextBox.Text = UserToEdit.User_Name;
            if(UserToEdit.Admin == true)
            {
                this.AdminStatus.SelectedIndex = 0;
            }
            else
            {
                this.AdminStatus.SelectedIndex = 1;
            }
        }

        private void DiscardChanges_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.PreviousForm.Show();
        }

        private void ResetPassword_Click(object sender, EventArgs e)
        {
            this.UserToEdit.Password = "1234";
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(this.UserToEdit);
                transaction.Commit();
            }
            session.Close();
            MessageBox.Show("Password for this user has been reset to 1234 and can be changed during the next login");
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(this.UserToEdit);
                transaction.Commit();
            }
            session.Close();
            MessageBox.Show("Changes Saved Successfully");
            this.Hide();
            this.PreviousForm.Show();
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.UserToEdit.User_Name = UserNameTextBox.Text;
        }

        private void AdminStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.AdminStatus.SelectedIndex == 0)
            {
                this.UserToEdit.Admin = true;
            }
            else
            {
                this.UserToEdit.Admin = false;
            }
        }
    }
}
