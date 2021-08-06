
namespace HCMSApplication
{
    partial class BrowseUsersForm
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.NewUser = new System.Windows.Forms.Button();
            this.EditUser = new System.Windows.Forms.Button();
            this.AdminStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Users_ListBox = new System.Windows.Forms.ListBox();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(678, 344);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 45);
            this.ClearButton.TabIndex = 23;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // NewUser
            // 
            this.NewUser.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NewUser.Enabled = false;
            this.NewUser.Location = new System.Drawing.Point(678, 242);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(112, 45);
            this.NewUser.TabIndex = 22;
            this.NewUser.Text = "New User";
            this.NewUser.UseVisualStyleBackColor = true;
            // 
            // EditUser
            // 
            this.EditUser.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.EditUser.Enabled = false;
            this.EditUser.Location = new System.Drawing.Point(678, 191);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(112, 45);
            this.EditUser.TabIndex = 21;
            this.EditUser.Text = "Edit User";
            this.EditUser.UseVisualStyleBackColor = true;
            // 
            // AdminStatus
            // 
            this.AdminStatus.FormattingEnabled = true;
            this.AdminStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.AdminStatus.Location = new System.Drawing.Point(550, 11);
            this.AdminStatus.Name = "AdminStatus";
            this.AdminStatus.Size = new System.Drawing.Size(121, 24);
            this.AdminStatus.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Admin Privilages: ";
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(291, 11);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.UserIDTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "User ID:";
            // 
            // UernameTextBox
            // 
            this.UernameTextBox.Location = new System.Drawing.Point(98, 11);
            this.UernameTextBox.Name = "UernameTextBox";
            this.UernameTextBox.Size = new System.Drawing.Size(100, 22);
            this.UernameTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username: ";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(678, 395);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(112, 45);
            this.Back.TabIndex = 14;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Users_ListBox
            // 
            this.Users_ListBox.FormattingEnabled = true;
            this.Users_ListBox.ItemHeight = 16;
            this.Users_ListBox.Location = new System.Drawing.Point(14, 68);
            this.Users_ListBox.Name = "Users_ListBox";
            this.Users_ListBox.Size = new System.Drawing.Size(628, 372);
            this.Users_ListBox.TabIndex = 13;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(678, 293);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(112, 45);
            this.Search.TabIndex = 12;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // BrowseUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
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
            this.Name = "BrowseUsersForm";
            this.Text = "BrowseUsersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button NewUser;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.ComboBox AdminStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ListBox Users_ListBox;
        private System.Windows.Forms.Button Search;
    }
}