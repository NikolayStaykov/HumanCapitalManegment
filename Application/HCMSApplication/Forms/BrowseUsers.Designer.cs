
namespace HCMSApplication.Forms
{
    partial class BrowseUsers
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
            this.Search = new System.Windows.Forms.Button();
            this.Users_ListBox = new System.Windows.Forms.ListBox();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminStatus = new System.Windows.Forms.ComboBox();
            this.EditUser = new System.Windows.Forms.Button();
            this.NewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(676, 393);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(112, 45);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Users_ListBox
            // 
            this.Users_ListBox.FormattingEnabled = true;
            this.Users_ListBox.ItemHeight = 16;
            this.Users_ListBox.Location = new System.Drawing.Point(127, 66);
            this.Users_ListBox.Name = "Users_ListBox";
            this.Users_ListBox.Size = new System.Drawing.Size(511, 372);
            this.Users_ListBox.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 393);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(94, 45);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username: ";
            // 
            // UernameTextBox
            // 
            this.UernameTextBox.Location = new System.Drawing.Point(96, 9);
            this.UernameTextBox.Name = "UernameTextBox";
            this.UernameTextBox.Size = new System.Drawing.Size(100, 22);
            this.UernameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "User ID:";
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(289, 9);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.UserIDTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Admin Privilages: ";
            // 
            // AdminStatus
            // 
            this.AdminStatus.FormattingEnabled = true;
            this.AdminStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.AdminStatus.Location = new System.Drawing.Point(548, 9);
            this.AdminStatus.Name = "AdminStatus";
            this.AdminStatus.Size = new System.Drawing.Size(121, 24);
            this.AdminStatus.TabIndex = 8;
            // 
            // EditUser
            // 
            this.EditUser.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.EditUser.Enabled = false;
            this.EditUser.Location = new System.Drawing.Point(676, 330);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(112, 45);
            this.EditUser.TabIndex = 9;
            this.EditUser.Text = "Edit User";
            this.EditUser.UseVisualStyleBackColor = true;
            // 
            // NewUser
            // 
            this.NewUser.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NewUser.Enabled = false;
            this.NewUser.Location = new System.Drawing.Point(676, 269);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(112, 45);
            this.NewUser.TabIndex = 10;
            this.NewUser.Text = "New User";
            this.NewUser.UseVisualStyleBackColor = true;
            // 
            // BrowseUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.EditUser);
            this.Controls.Add(this.AdminStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UernameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Users_ListBox);
            this.Controls.Add(this.Search);
            this.Name = "BrowseUsers";
            this.Text = "BrowseUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListBox Users_ListBox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AdminStatus;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.Button NewUser;
    }
}