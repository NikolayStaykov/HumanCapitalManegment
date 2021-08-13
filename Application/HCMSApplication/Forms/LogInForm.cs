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
using NHibernate.Cfg;
using MySql.Data;
using NHibernate.Criterion;

namespace HCMSApplication
{
    public partial class LogInForm : Form
    {
        private User CurrentUser;
        private ISessionFactory sessionFactory;
        private ISession session;
        public void setCurrentUser(User user)
        {
            this.CurrentUser = user;
        }
        public LogInForm()
        {
            InitializeComponent();
            this.CurrentUser = null;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            session = sessionFactory.OpenSession();
            using(session.BeginTransaction())
            {
                User user = session
                    .CreateCriteria(typeof(User))
                    .Add(Restrictions.Eq("User_Name", UserNameTextBox.Text.Trim()))
                    .Add(Restrictions.Eq("Password", PasswordTextBox.Text.Trim()))
                    .UniqueResult<User>();
                this.CurrentUser = user;
                session.Close();
                if (this.CurrentUser != null)
                {
                    MainMenuForm MainMenu = new MainMenuForm(this.CurrentUser);
                    MainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Credentials");
                }
            }
        }
    }
}
