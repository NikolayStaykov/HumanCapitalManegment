using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using MySql.Data;
using NHibernate.Criterion;

namespace HCMSApplication
{
    public partial class ChangePassword : Form
    {
        private User CurrrentUser;
        private Form PreviousForm;
        public ChangePassword(User user,Form form)
        {
            InitializeComponent();
            this.CurrrentUser = user;
            this.PreviousForm = form;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            string oldPassword = this.OldPasswordTextBox.Text.Trim();
            string newPassword = this.NewPasswordTextBox.Text.Trim();
            if(this.CurrrentUser.Password == oldPassword)
            {
                this.CurrrentUser.Password = newPassword;
                ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                ISession session = sessionFactory.OpenSession();
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(this.CurrrentUser);
                    transaction.Commit();
                }
                session.Close();
                MessageBox.Show("Password Changed Sucessfully");
                this.Hide();
                this.PreviousForm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect current password");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.PreviousForm.Show();
        }
    }
}
