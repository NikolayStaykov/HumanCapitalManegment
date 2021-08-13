
namespace HCMSApplication.Forms
{
    partial class EditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button DiscardChanges;
            System.Windows.Forms.Button ResetPassword;
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminStatus = new System.Windows.Forms.ComboBox();
            this.SaveChanges = new System.Windows.Forms.Button();
            DiscardChanges = new System.Windows.Forms.Button();
            ResetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DiscardChanges
            // 
            DiscardChanges.Location = new System.Drawing.Point(158, 173);
            DiscardChanges.Name = "DiscardChanges";
            DiscardChanges.Size = new System.Drawing.Size(113, 55);
            DiscardChanges.TabIndex = 8;
            DiscardChanges.Text = "Discard Changes";
            DiscardChanges.UseVisualStyleBackColor = true;
            DiscardChanges.Click += new System.EventHandler(this.DiscardChanges_Click);
            // 
            // ResetPassword
            // 
            ResetPassword.Location = new System.Drawing.Point(309, 173);
            ResetPassword.Name = "ResetPassword";
            ResetPassword.Size = new System.Drawing.Size(113, 55);
            ResetPassword.TabIndex = 9;
            ResetPassword.Text = "Reset Password";
            ResetPassword.UseVisualStyleBackColor = true;
            ResetPassword.Click += new System.EventHandler(this.ResetPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(99, 70);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(208, 22);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "User ID: ";
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(99, 30);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.ReadOnly = true;
            this.UserIDTextBox.Size = new System.Drawing.Size(208, 22);
            this.UserIDTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Admin Privilages:";
            // 
            // AdminStatus
            // 
            this.AdminStatus.FormattingEnabled = true;
            this.AdminStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.AdminStatus.Location = new System.Drawing.Point(134, 109);
            this.AdminStatus.Name = "AdminStatus";
            this.AdminStatus.Size = new System.Drawing.Size(173, 24);
            this.AdminStatus.TabIndex = 6;
            this.AdminStatus.SelectedIndexChanged += new System.EventHandler(this.AdminStatus_SelectedIndexChanged);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(15, 173);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(113, 55);
            this.SaveChanges.TabIndex = 7;
            this.SaveChanges.Text = "Save Changes";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(ResetPassword);
            this.Controls.Add(DiscardChanges);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.AdminStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AdminStatus;
        private System.Windows.Forms.Button SaveChanges;
    }
}