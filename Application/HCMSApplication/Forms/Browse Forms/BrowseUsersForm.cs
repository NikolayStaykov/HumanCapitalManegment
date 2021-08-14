using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCMSApplication.Forms;
using NHibernate;
using NHibernate.Criterion;

namespace HCMSApplication
{
    public partial class BrowseUsersForm : Form
    {
        private User CurrentUser;
        private Form PreviousForm;
        private IList<User> AllUsers;
        public void setCurrentUser(User user)
        {
            this.CurrentUser = user;
        }
        public void setPreviousForm(Form form)
        {
            this.PreviousForm = form;
        }
        public BrowseUsersForm(User user, Form form)
        {
            InitializeComponent();
            this.CurrentUser = user;
            this.PreviousForm = form;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.PreviousForm.Show();
            this.Hide();
        }

        private void BrowseUsersForm_Load(object sender, EventArgs e)
        {
            if(this.CurrentUser.Admin == true)
            {
                this.EditUser.Enabled = true;
                this.NewUserButton.Enabled = true;
            }
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                var users = session
                    .CreateCriteria(typeof(User))
                    .List<User>();
                this.AllUsers = users;
            }
            session.Close();
            foreach(User user in this.AllUsers)
            {
                this.Users_ListBox.Items.Add(user.ToString());
            }
        }

        private void NewUser_Click(object sender, EventArgs e)
        {
            Form NewUserForm = new HCMSApplication.Forms.NewUser(this.CurrentUser, this);
            NewUserForm.Show();
            this.Hide();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.UserIDTextBox.Text = "";
            this.UserNameTextBox.Text = "";
            this.AdminStatus.SelectedIndex = -1;
            this.Users_ListBox.Items.Clear();
            this.Search_Click(sender, e);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                ICriteria cr = session.CreateCriteria(typeof(User));
                if(this.UserNameTextBox.Text.Trim() != "")
                {
                    cr.Add(Restrictions.Eq("User_Name", this.UserNameTextBox.Text.Trim()));
                }
                if(this.UserIDTextBox.Text.Trim() != "")
                {
                    int user_id = Int32.Parse(this.UserIDTextBox.Text);
                    cr.Add(Restrictions.Eq("ID", user_id));
                }
                if(AdminStatus.SelectedIndex != -1)
                {
                    if(AdminStatus.SelectedIndex == 0)
                    {
                        cr.Add(Restrictions.Eq("Admin", true));
                    }
                    else
                    {
                        cr.Add(Restrictions.Eq("Admin", false));
                    }
                }
                this.AllUsers = cr.List<User>();
            }
            session.Close();
            this.Users_ListBox.Items.Clear();
            foreach (User user in this.AllUsers)
            {
                this.Users_ListBox.Items.Add(user.ToString());
            }
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            if(Users_ListBox.SelectedIndex != -1)
            {
                Form EditUserForm = new HCMSApplication.Forms.EditUser(this.CurrentUser, this.AllUsers[Users_ListBox.SelectedIndex], this);
                EditUserForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select User to edit!");
            }
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (this.Users_ListBox.SelectedIndex != -1)
            {
                ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                ISession session = sessionFactory.OpenSession();
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(this.AllUsers[this.Users_ListBox.SelectedIndex]);
                    transaction.Commit();
                }
                session.Close();
                this.ClearButton_Click(sender, e);
                this.Search_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select department to delete");
            }
        }
    }
}
