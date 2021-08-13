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
    public partial class NewPosition : Form
    {
        private User CurrentUSer;
        private Form previousForm;
        private int DepartmentID;
        public NewPosition(User user, Form form,int departmentID)
        {
            InitializeComponent();
            this.CurrentUSer = user;
            this.previousForm = form;
            this.DepartmentID = departmentID;
        }

        private void NewPosition_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.previousForm.Show();
        }

        private void SavePositionButton_Click(object sender, EventArgs e)
        {
            if (PositionNameBox.Text.Trim() != "")
            {
                if(DescriptionTextBox.Text.Trim() != "")
                {
                    Position newPosition = new Position(0, this.DepartmentID, this.PositionNameBox.Text.Trim(),this.DescriptionTextBox.Text.Trim());
                    ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                    ISession session = sessionFactory.OpenSession();
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(newPosition);
                        transaction.Commit();
                    }
                    session.Close();
                    MessageBox.Show("Position Saved Sucessfully.");
                }
                else
                {
                    MessageBox.Show("Please Enter Description for Position");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Name for Position");
            }
        }
    }
}
