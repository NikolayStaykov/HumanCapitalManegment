
namespace HCMSApplication.Forms.Creation_Forms
{
    partial class NewLeaveRequest
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
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EndDateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.StartDateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveLeaveRequestButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HolidayLeaveTextBox = new System.Windows.Forms.TextBox();
            this.MaternalLeaveTextBox = new System.Windows.Forms.TextBox();
            this.SickLeaveTextBox = new System.Windows.Forms.TextBox();
            this.UnpaidLeaveTextBox = new System.Windows.Forms.TextBox();
            this.PaidLeaveTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Maternal Leave",
            "Sick Leave",
            "Annual Paid Leave",
            "Annual Unpaid Leave",
            "Holiday Leave"});
            this.TypeComboBox.Location = new System.Drawing.Point(109, 154);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(206, 24);
            this.TypeComboBox.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Leave Type: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Approoval Status: ";
            // 
            // EndDateTime
            // 
            this.EndDateTime.Location = new System.Drawing.Point(59, 92);
            this.EndDateTime.Name = "EndDateTime";
            this.EndDateTime.Size = new System.Drawing.Size(256, 22);
            this.EndDateTime.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "End: ";
            // 
            // StartDateTime
            // 
            this.StartDateTime.Location = new System.Drawing.Point(64, 64);
            this.StartDateTime.Name = "StartDateTime";
            this.StartDateTime.Size = new System.Drawing.Size(251, 22);
            this.StartDateTime.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Start: ";
            // 
            // SaveLeaveRequestButton
            // 
            this.SaveLeaveRequestButton.Location = new System.Drawing.Point(677, 284);
            this.SaveLeaveRequestButton.Name = "SaveLeaveRequestButton";
            this.SaveLeaveRequestButton.Size = new System.Drawing.Size(111, 62);
            this.SaveLeaveRequestButton.TabIndex = 29;
            this.SaveLeaveRequestButton.Text = "Save Leave Request";
            this.SaveLeaveRequestButton.UseVisualStyleBackColor = true;
            this.SaveLeaveRequestButton.Click += new System.EventHandler(this.SaveLeaveRequestButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(677, 352);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(111, 62);
            this.BackButton.TabIndex = 27;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(109, 36);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.ReadOnly = true;
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(206, 22);
            this.EmployeeIDTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Employee ID:";
            // 
            // HolidayLeaveTextBox
            // 
            this.HolidayLeaveTextBox.Location = new System.Drawing.Point(119, 410);
            this.HolidayLeaveTextBox.Name = "HolidayLeaveTextBox";
            this.HolidayLeaveTextBox.ReadOnly = true;
            this.HolidayLeaveTextBox.Size = new System.Drawing.Size(196, 22);
            this.HolidayLeaveTextBox.TabIndex = 94;
            // 
            // MaternalLeaveTextBox
            // 
            this.MaternalLeaveTextBox.Location = new System.Drawing.Point(127, 363);
            this.MaternalLeaveTextBox.Name = "MaternalLeaveTextBox";
            this.MaternalLeaveTextBox.ReadOnly = true;
            this.MaternalLeaveTextBox.Size = new System.Drawing.Size(188, 22);
            this.MaternalLeaveTextBox.TabIndex = 93;
            // 
            // SickLeaveTextBox
            // 
            this.SickLeaveTextBox.Location = new System.Drawing.Point(144, 315);
            this.SickLeaveTextBox.Name = "SickLeaveTextBox";
            this.SickLeaveTextBox.ReadOnly = true;
            this.SickLeaveTextBox.Size = new System.Drawing.Size(171, 22);
            this.SickLeaveTextBox.TabIndex = 92;
            // 
            // UnpaidLeaveTextBox
            // 
            this.UnpaidLeaveTextBox.Location = new System.Drawing.Point(163, 271);
            this.UnpaidLeaveTextBox.Name = "UnpaidLeaveTextBox";
            this.UnpaidLeaveTextBox.ReadOnly = true;
            this.UnpaidLeaveTextBox.Size = new System.Drawing.Size(152, 22);
            this.UnpaidLeaveTextBox.TabIndex = 91;
            // 
            // PaidLeaveTextBox
            // 
            this.PaidLeaveTextBox.Location = new System.Drawing.Point(147, 229);
            this.PaidLeaveTextBox.Name = "PaidLeaveTextBox";
            this.PaidLeaveTextBox.ReadOnly = true;
            this.PaidLeaveTextBox.Size = new System.Drawing.Size(168, 22);
            this.PaidLeaveTextBox.TabIndex = 90;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 410);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 17);
            this.label14.TabIndex = 89;
            this.label14.Text = "Holiday leave: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 17);
            this.label13.TabIndex = 88;
            this.label13.Text = "Maternal leave: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 17);
            this.label12.TabIndex = 87;
            this.label12.Text = "Annual sick leave: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 17);
            this.label11.TabIndex = 86;
            this.label11.Text = "Annual unpaid leave: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 17);
            this.label10.TabIndex = 85;
            this.label10.Text = "Annual paid leave: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 95;
            this.label6.Text = "Leave Balance: ";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Enabled = false;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Approoved",
            "Pending",
            "Denied"});
            this.StatusComboBox.Location = new System.Drawing.Point(142, 125);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(173, 24);
            this.StatusComboBox.TabIndex = 37;
            // 
            // NewLeaveRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EndDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveLeaveRequestButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NewLeaveRequest";
            this.Text = "NewLeaveRequest";
            this.Load += new System.EventHandler(this.NewLeaveRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EndDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker StartDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveLeaveRequestButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HolidayLeaveTextBox;
        private System.Windows.Forms.TextBox MaternalLeaveTextBox;
        private System.Windows.Forms.TextBox SickLeaveTextBox;
        private System.Windows.Forms.TextBox UnpaidLeaveTextBox;
        private System.Windows.Forms.TextBox PaidLeaveTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox StatusComboBox;
    }
}