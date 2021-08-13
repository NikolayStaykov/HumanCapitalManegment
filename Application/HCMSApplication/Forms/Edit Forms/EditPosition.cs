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
    public partial class EditPosition : Form
    {
        private User CurrentUSer;
        private Form PreviousForm;
        private Position PositionToEdit;
        public EditPosition(User user,Form form,Position position)
        {
            InitializeComponent();
            this.CurrentUSer = user;
            this.PreviousForm = form;
            this.PositionToEdit = position;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.PreviousForm.Show();
        }

        private void EditPosition_Load(object sender, EventArgs e)
        {
            this.PositionIDTextBox.Text = PositionToEdit.ID.ToString();
            this.PositionNameBox.Text = PositionToEdit.Name;
            this.DescriptionTextBox.Text = PositionToEdit.Description;
        }

        private void PositionNameBox_TextChanged(object sender, EventArgs e)
        {
            this.PositionToEdit.Name = PositionNameBox.Text.Trim();
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            this.PositionToEdit.Description = DescriptionTextBox.Text.Trim();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            ISessionFactory sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(this.PositionToEdit);
                transaction.Commit();
            }
            session.Close();
            MessageBox.Show("Changes Saved Successfully");
            this.Hide();
            this.PreviousForm.Show();
        }
    }
}
