using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCMSApplication
{
    public partial class LogInForm : Form
    {
        private User CurrentUser;

        public void setCurrentUser(User user)
        {
            this.CurrentUser = user;
        }
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            CurrentUser = new User(0, "admin", "admin", true);
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            MainMenuForm MainMenu = new MainMenuForm(this.CurrentUser);
            //MainMenu.setCurrentUser(this.CurrentUser);
            MainMenu.Show();
            this.Hide();
        }
    }
}
