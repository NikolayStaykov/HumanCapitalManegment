
namespace HCMSApplication
{
    partial class BrowseDepartmentsForm
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
            this.EditButton = new System.Windows.Forms.Button();
            this.NewDepartmentButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.DepartmentsListBox = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteDepartmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(677, 284);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(111, 62);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Clear all ";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(677, 80);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(111, 62);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Edit Department";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NewDepartmentButton
            // 
            this.NewDepartmentButton.Location = new System.Drawing.Point(677, 148);
            this.NewDepartmentButton.Name = "NewDepartmentButton";
            this.NewDepartmentButton.Size = new System.Drawing.Size(111, 62);
            this.NewDepartmentButton.TabIndex = 13;
            this.NewDepartmentButton.Text = "New Department";
            this.NewDepartmentButton.UseVisualStyleBackColor = true;
            this.NewDepartmentButton.Click += new System.EventHandler(this.NewDepartment_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(677, 216);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(111, 62);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(677, 352);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(111, 62);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DepartmentsListBox
            // 
            this.DepartmentsListBox.FormattingEnabled = true;
            this.DepartmentsListBox.ItemHeight = 16;
            this.DepartmentsListBox.Location = new System.Drawing.Point(15, 186);
            this.DepartmentsListBox.Name = "DepartmentsListBox";
            this.DepartmentsListBox.Size = new System.Drawing.Size(559, 228);
            this.DepartmentsListBox.TabIndex = 10;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(71, 36);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(132, 22);
            this.NameTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name: ";
            // 
            // DeleteDepartmentButton
            // 
            this.DeleteDepartmentButton.Enabled = false;
            this.DeleteDepartmentButton.Location = new System.Drawing.Point(677, 12);
            this.DeleteDepartmentButton.Name = "DeleteDepartmentButton";
            this.DeleteDepartmentButton.Size = new System.Drawing.Size(111, 62);
            this.DeleteDepartmentButton.TabIndex = 16;
            this.DeleteDepartmentButton.Text = "Delete Department";
            this.DeleteDepartmentButton.UseVisualStyleBackColor = true;
            this.DeleteDepartmentButton.Click += new System.EventHandler(this.DeleteDepartmentButton_Click);
            // 
            // BrowseDepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteDepartmentButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NewDepartmentButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DepartmentsListBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BrowseDepartmentsForm";
            this.Text = "BrowseDepartmentsForm";
            this.Load += new System.EventHandler(this.BrowseDepartmentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button NewDepartmentButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListBox DepartmentsListBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteDepartmentButton;
    }
}