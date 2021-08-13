
namespace HCMSApplication
{
    partial class BrowseEmployeesForm
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.NewEmployeeButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
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
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EmploymentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new System.Drawing.Point(715, 386);
            BackButton.Name = "BackButton";
            BackButton.Size = new System.Drawing.Size(75, 53);
            BackButton.TabIndex = 42;
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
            this.DepartmentComboBox.Size = new System.Drawing.Size(200, 24);
            this.DepartmentComboBox.TabIndex = 35;
            this.DepartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentComboBox_SelectedIndexChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(715, 327);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 53);
            this.ClearButton.TabIndex = 43;
            this.ClearButton.Text = "Clear all ";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // NewEmployeeButton
            // 
            this.NewEmployeeButton.Location = new System.Drawing.Point(715, 209);
            this.NewEmployeeButton.Name = "NewEmployeeButton";
            this.NewEmployeeButton.Size = new System.Drawing.Size(75, 53);
            this.NewEmployeeButton.TabIndex = 41;
            this.NewEmployeeButton.Text = "New Employee";
            this.NewEmployeeButton.UseVisualStyleBackColor = true;
            this.NewEmployeeButton.Click += new System.EventHandler(this.NewEmployeeButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(715, 150);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 53);
            this.EditButton.TabIndex = 40;
            this.EditButton.Text = "Edit Employee";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(715, 268);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 53);
            this.SearchButton.TabIndex = 39;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(418, 99);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(230, 22);
            this.SalaryTextBox.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Salary: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Department:";
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Location = new System.Drawing.Point(424, 10);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(224, 24);
            this.PositionComboBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Position:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(81, 147);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(165, 22);
            this.AddressTextBox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Address:";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(66, 114);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(180, 22);
            this.PhoneTextBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Phone: ";
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(108, 10);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(138, 22);
            this.EmployeeIDTextBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Employee ID:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(66, 83);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(180, 22);
            this.EmailTextBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Email: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(66, 47);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(180, 22);
            this.NameTextBox.TabIndex = 23;
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.HorizontalScrollbar = true;
            this.EmployeesListBox.ItemHeight = 16;
            this.EmployeesListBox.Location = new System.Drawing.Point(14, 180);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(681, 260);
            this.EmployeesListBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Employment Status:";
            // 
            // EmploymentStatusComboBox
            // 
            this.EmploymentStatusComboBox.FormattingEnabled = true;
            this.EmploymentStatusComboBox.Items.AddRange(new object[] {
            "Active",
            "Terminated"});
            this.EmploymentStatusComboBox.Location = new System.Drawing.Point(495, 145);
            this.EmploymentStatusComboBox.Name = "EmploymentStatusComboBox";
            this.EmploymentStatusComboBox.Size = new System.Drawing.Size(153, 24);
            this.EmploymentStatusComboBox.TabIndex = 45;
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Enabled = false;
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(713, 91);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(75, 53);
            this.DeleteEmployeeButton.TabIndex = 46;
            this.DeleteEmployeeButton.Text = "Delete Employee";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // BrowseEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.EmploymentStatusComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(BackButton);
            this.Controls.Add(this.NewEmployeeButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SearchButton);
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
            this.Controls.Add(this.EmployeesListBox);
            this.Name = "BrowseEmployeesForm";
            this.Text = "BrowseEmployeesForm";
            this.Load += new System.EventHandler(this.BrowseEmployeesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button NewEmployeeButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SearchButton;
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
        private System.Windows.Forms.ListBox EmployeesListBox;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox EmploymentStatusComboBox;
        private System.Windows.Forms.Button DeleteEmployeeButton;
    }
}