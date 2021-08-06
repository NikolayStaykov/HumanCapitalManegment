
namespace HCMSApplication
{
    partial class BrowseLeaveRequestsForm
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
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EndDateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.StartDateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.NewLeaveRequestButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LeaveRequestsListBox = new System.Windows.Forms.ListBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "",
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
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "",
            "Approoved",
            "Pending",
            "Denied"});
            this.StatusComboBox.Location = new System.Drawing.Point(142, 125);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(173, 24);
            this.StatusComboBox.TabIndex = 37;
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
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(677, 284);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(111, 62);
            this.ClearButton.TabIndex = 31;
            this.ClearButton.Text = "Clear all ";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(677, 80);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(111, 62);
            this.EditButton.TabIndex = 30;
            this.EditButton.Text = "Edit Leave Request";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // NewLeaveRequestButton
            // 
            this.NewLeaveRequestButton.Location = new System.Drawing.Point(677, 148);
            this.NewLeaveRequestButton.Name = "NewLeaveRequestButton";
            this.NewLeaveRequestButton.Size = new System.Drawing.Size(111, 62);
            this.NewLeaveRequestButton.TabIndex = 29;
            this.NewLeaveRequestButton.Text = "New Leave Request";
            this.NewLeaveRequestButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(677, 216);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(111, 62);
            this.SearchButton.TabIndex = 28;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
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
            // LeaveRequestsListBox
            // 
            this.LeaveRequestsListBox.FormattingEnabled = true;
            this.LeaveRequestsListBox.ItemHeight = 16;
            this.LeaveRequestsListBox.Location = new System.Drawing.Point(15, 186);
            this.LeaveRequestsListBox.Name = "LeaveRequestsListBox";
            this.LeaveRequestsListBox.Size = new System.Drawing.Size(559, 228);
            this.LeaveRequestsListBox.TabIndex = 26;
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(109, 36);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
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
            // BrowseLeaveRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EndDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NewLeaveRequestButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LeaveRequestsListBox);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BrowseLeaveRequestsForm";
            this.Text = "BrowseLeaveRequestsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EndDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker StartDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button NewLeaveRequestButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListBox LeaveRequestsListBox;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.Label label1;
    }
}