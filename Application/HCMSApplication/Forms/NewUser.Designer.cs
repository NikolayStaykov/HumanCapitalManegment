
namespace HCMSApplication.Forms
{
    partial class NewUser
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
            System.Windows.Forms.Button CreateUser;
            System.Windows.Forms.Button Back;
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminStatus = new System.Windows.Forms.ComboBox();
            CreateUser = new System.Windows.Forms.Button();
            Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username: ";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(99, 9);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(208, 22);
            this.UserNameTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Admin Privilages:";
            // 
            // AdminStatus
            // 
            this.AdminStatus.FormattingEnabled = true;
            this.AdminStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.AdminStatus.Location = new System.Drawing.Point(134, 48);
            this.AdminStatus.Name = "AdminStatus";
            this.AdminStatus.Size = new System.Drawing.Size(173, 24);
            this.AdminStatus.TabIndex = 15;
            // 
            // CreateUser
            // 
            CreateUser.Location = new System.Drawing.Point(15, 112);
            CreateUser.Name = "CreateUser";
            CreateUser.Size = new System.Drawing.Size(113, 55);
            CreateUser.TabIndex = 16;
            CreateUser.Text = "Create User";
            CreateUser.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            Back.Location = new System.Drawing.Point(158, 112);
            Back.Name = "Back";
            Back.Size = new System.Drawing.Size(113, 55);
            Back.TabIndex = 17;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(Back);
            this.Controls.Add(CreateUser);
            this.Controls.Add(this.AdminStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AdminStatus;
    }
}