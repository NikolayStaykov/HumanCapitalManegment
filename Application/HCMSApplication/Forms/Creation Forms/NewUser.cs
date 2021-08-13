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
    public partial class NewUser : Form
    {
        private User CurrentUser;
        private Form PreviousForm;
        public NewUser(User user, Form form)
        {
            InitializeComponent();
            this.CurrentUser = user;
            this.PreviousForm = form;
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            this.AdminStatus.SelectedIndex = 0;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.PreviousForm.Show();
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            bool adminPrivileges = true;
            if (this.UserNameTextBox.Text.Trim() != "")
            {
                if (this.AdminStatus.SelectedIndex == 1)
                {
                    adminPrivileges = true;
                }
                else
                {
                    adminPrivileges = false;
                }
                User newUser = new User(0, this.UserNameTextBox.Text.Trim(), "1234", adminPrivileges);
                ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                ISession session = sessionFactory.OpenSession();
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(newUser);
                    transaction.Commit();
                }
                session.Close();
                MessageBox.Show("Password for new User is 1234 please make sure to change it after first log in.");
            }
            else
            {
                MessageBox.Show("Please fill out all fields");
            }
        }
    }
}
