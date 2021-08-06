
namespace HCMSApplication.Forms
{
    partial class EditDepartment
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DepartmentIDTextBox = new System.Windows.Forms.TextBox();
            this.PositionsListBox = new System.Windows.Forms.ListBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.EditPositionButton = new System.Windows.Forms.Button();
            this.NewPositionButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(67, 49);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(157, 22);
            this.NameTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department ID:";
            // 
            // DepartmentIDTextBox
            // 
            this.DepartmentIDTextBox.Location = new System.Drawing.Point(124, 4);
            this.DepartmentIDTextBox.Name = "DepartmentIDTextBox";
            this.DepartmentIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.DepartmentIDTextBox.TabIndex = 5;
            // 
            // PositionsListBox
            // 
            this.PositionsListBox.FormattingEnabled = true;
            this.PositionsListBox.ItemHeight = 16;
            this.PositionsListBox.Location = new System.Drawing.Point(15, 201);
            this.PositionsListBox.Name = "PositionsListBox";
            this.PositionsListBox.Size = new System.Drawing.Size(644, 228);
            this.PositionsListBox.TabIndex = 6;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(665, 376);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(123, 53);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // EditPositionButton
            // 
            this.EditPositionButton.Location = new System.Drawing.Point(665, 317);
            this.EditPositionButton.Name = "EditPositionButton";
            this.EditPositionButton.Size = new System.Drawing.Size(123, 53);
            this.EditPositionButton.TabIndex = 8;
            this.EditPositionButton.Text = "Edit Position";
            this.EditPositionButton.UseVisualStyleBackColor = true;
            // 
            // NewPositionButton
            // 
            this.NewPositionButton.Location = new System.Drawing.Point(665, 258);
            this.NewPositionButton.Name = "NewPositionButton";
            this.NewPositionButton.Size = new System.Drawing.Size(123, 53);
            this.NewPositionButton.TabIndex = 9;
            this.NewPositionButton.Text = "New Position";
            this.NewPositionButton.UseVisualStyleBackColor = true;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(665, 199);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(123, 53);
            this.SaveChangesButton.TabIndex = 10;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            // 
            // EditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.NewPositionButton);
            this.Controls.Add(this.EditPositionButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PositionsListBox);
            this.Controls.Add(this.DepartmentIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EditDepartment";
            this.Text = "EditDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DepartmentIDTextBox;
        private System.Windows.Forms.ListBox PositionsListBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EditPositionButton;
        private System.Windows.Forms.Button NewPositionButton;
        private System.Windows.Forms.Button SaveChangesButton;
    }
}