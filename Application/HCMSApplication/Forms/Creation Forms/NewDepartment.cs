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
    public partial class NewDepartment : Form
    {
        private User CurrentUser;
        private Form PreviousForm;
        public NewDepartment(User user,Form form)
        {
            InitializeComponent();
            this.CurrentUser = user;
            this.PreviousForm = form;
        }

        private void NewDepartment_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.PreviousForm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(this.NameTextBox.Text != "")
            {
                Department newDepartment = new Department(0, this.NameTextBox.Text.Trim());
                ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                ISession session = sessionFactory.OpenSession();
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(newDepartment);
                    transaction.Commit();
                }
                session.Close();
                MessageBox.Show("New Department Saved Sucessfully");
                this.Hide();
                this.PreviousForm.Show();
            }
            else
            {
                MessageBox.Show("Please enter name for the new department");
            }
        }
    }
}
