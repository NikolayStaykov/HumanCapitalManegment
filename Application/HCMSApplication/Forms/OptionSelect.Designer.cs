
namespace HCMSApplication.Forms
{
    partial class Main_Menu
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
            this.UsersButton = new System.Windows.Forms.Button();
            this.LeaveRequests = new System.Windows.Forms.Button();
            this.DepartmentsButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersButton
            // 
            this.UsersButton.Location = new System.Drawing.Point(336, 305);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(134, 56);
            this.UsersButton.TabIndex = 0;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Visible = false;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // LeaveRequests
            // 
            this.LeaveRequests.Location = new System.Drawing.Point(336, 243);
            this.LeaveRequests.Name = "LeaveRequests";
            this.LeaveRequests.Size = new System.Drawing.Size(134, 56);
            this.LeaveRequests.TabIndex = 1;
            this.LeaveRequests.Text = "Leave Requests";
            this.LeaveRequests.UseVisualStyleBackColor = true;
            this.LeaveRequests.Click += new System.EventHandler(this.LeaveRequests_Click);
            // 
            // DepartmentsButton
            // 
            this.DepartmentsButton.Location = new System.Drawing.Point(336, 181);
            this.DepartmentsButton.Name = "DepartmentsButton";
            this.DepartmentsButton.Size = new System.Drawing.Size(134, 56);
            this.DepartmentsButton.TabIndex = 2;
            this.DepartmentsButton.Text = "Departments";
            this.DepartmentsButton.UseVisualStyleBackColor = true;
            this.DepartmentsButton.Click += new System.EventHandler(this.DepartmentsButton_Click);
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Location = new System.Drawing.Point(336, 119);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(134, 56);
            this.EmployeesButton.TabIndex = 3;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeesButton);
            this.Controls.Add(this.DepartmentsButton);
            this.Controls.Add(this.LeaveRequests);
            this.Controls.Add(this.UsersButton);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button LeaveRequests;
        private System.Windows.Forms.Button DepartmentsButton;
        private System.Windows.Forms.Button EmployeesButton;
    }
}