
namespace HCMSApplication
{
    partial class MainMenuForm
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
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.DepartmentsButton = new System.Windows.Forms.Button();
            this.LeaveRequestsButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Location = new System.Drawing.Point(315, 88);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(159, 44);
            this.EmployeesButton.TabIndex = 0;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // DepartmentsButton
            // 
            this.DepartmentsButton.Location = new System.Drawing.Point(315, 161);
            this.DepartmentsButton.Name = "DepartmentsButton";
            this.DepartmentsButton.Size = new System.Drawing.Size(159, 44);
            this.DepartmentsButton.TabIndex = 1;
            this.DepartmentsButton.Text = "Departments";
            this.DepartmentsButton.UseVisualStyleBackColor = true;
            this.DepartmentsButton.Click += new System.EventHandler(this.DepartmentsButton_Click);
            // 
            // LeaveRequestsButton
            // 
            this.LeaveRequestsButton.Location = new System.Drawing.Point(315, 235);
            this.LeaveRequestsButton.Name = "LeaveRequestsButton";
            this.LeaveRequestsButton.Size = new System.Drawing.Size(159, 44);
            this.LeaveRequestsButton.TabIndex = 2;
            this.LeaveRequestsButton.Text = "Leave Requests";
            this.LeaveRequestsButton.UseVisualStyleBackColor = true;
            this.LeaveRequestsButton.Click += new System.EventHandler(this.LeaveRequestsButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.Enabled = false;
            this.UsersButton.Location = new System.Drawing.Point(315, 305);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(159, 44);
            this.UsersButton.TabIndex = 3;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(12, 12);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(181, 23);
            this.ChangePasswordButton.TabIndex = 4;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(315, 372);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(159, 44);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.LeaveRequestsButton);
            this.Controls.Add(this.DepartmentsButton);
            this.Controls.Add(this.EmployeesButton);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button DepartmentsButton;
        private System.Windows.Forms.Button LeaveRequestsButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button QuitButton;
    }
}