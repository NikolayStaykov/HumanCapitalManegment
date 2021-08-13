
namespace HCMSApplication.Forms
{
    partial class EditEmployee
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
            System.Windows.Forms.Button BackButton;
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.EmergencyContactTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PaidLeaveTextBox = new System.Windows.Forms.TextBox();
            this.UnpaidLeaveTextBox = new System.Windows.Forms.TextBox();
            this.SickLeaveTextBox = new System.Windows.Forms.TextBox();
            this.MaternalLeaveTextBox = new System.Windows.Forms.TextBox();
            this.HolidayLeaveTextBox = new System.Windows.Forms.TextBox();
            this.NewLeaveRequest = new System.Windows.Forms.Button();
            this.EmploymentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new System.Drawing.Point(690, 365);
            BackButton.Name = "BackButton";
            BackButton.Size = new System.Drawing.Size(98, 53);
            BackButton.TabIndex = 41;
            BackButton.Text = "Back";
            BackButton.UseMnemonic = false;
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(448, 49);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(201, 24);
            this.DepartmentComboBox.TabIndex = 34;
            this.DepartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentComboBox_SelectedIndexChanged);
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(418, 99);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(231, 22);
            this.SalaryTextBox.TabIndex = 37;
            this.SalaryTextBox.TextChanged += new System.EventHandler(this.SalaryTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Salary: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Department:";
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Location = new System.Drawing.Point(424, 10);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(225, 24);
            this.PositionComboBox.TabIndex = 33;
            this.PositionComboBox.SelectedIndexChanged += new System.EventHandler(this.PositionComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Position:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(81, 147);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(165, 22);
            this.AddressTextBox.TabIndex = 31;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Address:";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(66, 114);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(180, 22);
            this.PhoneTextBox.TabIndex = 29;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Phone: ";
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(108, 10);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.ReadOnly = true;
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(138, 22);
            this.EmployeeIDTextBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Employee ID:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(66, 83);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(180, 22);
            this.EmailTextBox.TabIndex = 25;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(66, 47);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(180, 22);
            this.NameTextBox.TabIndex = 22;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(690, 306);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(98, 53);
            this.SaveChangesButton.TabIndex = 42;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Emergency Contact: ";
            // 
            // EmergencyContactTextBox
            // 
            this.EmergencyContactTextBox.Location = new System.Drawing.Point(501, 147);
            this.EmergencyContactTextBox.Name = "EmergencyContactTextBox";
            this.EmergencyContactTextBox.Size = new System.Drawing.Size(148, 22);
            this.EmergencyContactTextBox.TabIndex = 44;
            this.EmergencyContactTextBox.TextChanged += new System.EventHandler(this.EmergencyContactTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "Annual paid leave: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "Annual unpaid leave: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "Annual sick leave: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "Maternal leave: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 401);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 17);
            this.label14.TabIndex = 49;
            this.label14.Text = "Holiday leave: ";
            // 
            // PaidLeaveTextBox
            // 
            this.PaidLeaveTextBox.Location = new System.Drawing.Point(146, 220);
            this.PaidLeaveTextBox.Name = "PaidLeaveTextBox";
            this.PaidLeaveTextBox.ReadOnly = true;
            this.PaidLeaveTextBox.Size = new System.Drawing.Size(168, 22);
            this.PaidLeaveTextBox.TabIndex = 50;
            this.PaidLeaveTextBox.TextChanged += new System.EventHandler(this.PaidLeaveTextBox_TextChanged);
            // 
            // UnpaidLeaveTextBox
            // 
            this.UnpaidLeaveTextBox.Location = new System.Drawing.Point(162, 262);
            this.UnpaidLeaveTextBox.Name = "UnpaidLeaveTextBox";
            this.UnpaidLeaveTextBox.ReadOnly = true;
            this.UnpaidLeaveTextBox.Size = new System.Drawing.Size(152, 22);
            this.UnpaidLeaveTextBox.TabIndex = 51;
            this.UnpaidLeaveTextBox.TextChanged += new System.EventHandler(this.UnpaidLeaveTextBox_TextChanged);
            // 
            // SickLeaveTextBox
            // 
            this.SickLeaveTextBox.Location = new System.Drawing.Point(143, 306);
            this.SickLeaveTextBox.Name = "SickLeaveTextBox";
            this.SickLeaveTextBox.ReadOnly = true;
            this.SickLeaveTextBox.Size = new System.Drawing.Size(171, 22);
            this.SickLeaveTextBox.TabIndex = 52;
            this.SickLeaveTextBox.TextChanged += new System.EventHandler(this.SickLeaveTextBox_TextChanged);
            // 
            // MaternalLeaveTextBox
            // 
            this.MaternalLeaveTextBox.Location = new System.Drawing.Point(126, 354);
            this.MaternalLeaveTextBox.Name = "MaternalLeaveTextBox";
            this.MaternalLeaveTextBox.ReadOnly = true;
            this.MaternalLeaveTextBox.Size = new System.Drawing.Size(188, 22);
            this.MaternalLeaveTextBox.TabIndex = 53;
            this.MaternalLeaveTextBox.TextChanged += new System.EventHandler(this.MaternalLeaveTextBox_TextChanged);
            // 
            // HolidayLeaveTextBox
            // 
            this.HolidayLeaveTextBox.Location = new System.Drawing.Point(118, 401);
            this.HolidayLeaveTextBox.Name = "HolidayLeaveTextBox";
            this.HolidayLeaveTextBox.ReadOnly = true;
            this.HolidayLeaveTextBox.Size = new System.Drawing.Size(196, 22);
            this.HolidayLeaveTextBox.TabIndex = 54;
            this.HolidayLeaveTextBox.TextChanged += new System.EventHandler(this.HolidayLeaveTextBox_TextChanged);
            // 
            // NewLeaveRequest
            // 
            this.NewLeaveRequest.Location = new System.Drawing.Point(690, 247);
            this.NewLeaveRequest.Name = "NewLeaveRequest";
            this.NewLeaveRequest.Size = new System.Drawing.Size(98, 53);
            this.NewLeaveRequest.TabIndex = 55;
            this.NewLeaveRequest.Text = "New Leave Request";
            this.NewLeaveRequest.UseVisualStyleBackColor = true;
            this.NewLeaveRequest.Click += new System.EventHandler(this.NewLeaveRequest_Click);
            // 
            // EmploymentStatusComboBox
            // 
            this.EmploymentStatusComboBox.FormattingEnabled = true;
            this.EmploymentStatusComboBox.Items.AddRange(new object[] {
            "Active",
            "Terminated"});
            this.EmploymentStatusComboBox.Location = new System.Drawing.Point(495, 185);
            this.EmploymentStatusComboBox.Name = "EmploymentStatusComboBox";
            this.EmploymentStatusComboBox.Size = new System.Drawing.Size(153, 24);
            this.EmploymentStatusComboBox.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(356, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 17);
            this.label15.TabIndex = 56;
            this.label15.Text = "Employment Status:";
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmploymentStatusComboBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.NewLeaveRequest);
            this.Controls.Add(this.HolidayLeaveTextBox);
            this.Controls.Add(this.MaternalLeaveTextBox);
            this.Controls.Add(this.SickLeaveTextBox);
            this.Controls.Add(this.UnpaidLeaveTextBox);
            this.Controls.Add(this.PaidLeaveTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EmergencyContactTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(BackButton);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DepartmentComboBox);
            this.Controls.Add(this.PositionComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Name = "EditEmployee";
            this.Text = "mo";
            this.Load += new System.EventHandler(this.EditEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EmergencyContactTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PaidLeaveTextBox;
        private System.Windows.Forms.TextBox UnpaidLeaveTextBox;
        private System.Windows.Forms.TextBox SickLeaveTextBox;
        private System.Windows.Forms.TextBox MaternalLeaveTextBox;
        private System.Windows.Forms.TextBox HolidayLeaveTextBox;
        private System.Windows.Forms.Button NewLeaveRequest;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.ComboBox EmploymentStatusComboBox;
        private System.Windows.Forms.Label label15;
    }
}