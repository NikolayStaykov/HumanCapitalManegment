
namespace HCMSApplication.Forms
{
    partial class NewPosition
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
            this.label1 = new System.Windows.Forms.Label();
            this.PositionIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PositionNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SavePositionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position ID: ";
            // 
            // PositionIDTextBox
            // 
            this.PositionIDTextBox.Location = new System.Drawing.Point(101, 9);
            this.PositionIDTextBox.Name = "PositionIDTextBox";
            this.PositionIDTextBox.ReadOnly = true;
            this.PositionIDTextBox.Size = new System.Drawing.Size(232, 22);
            this.PositionIDTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name: ";
            // 
            // PositionNameBox
            // 
            this.PositionNameBox.Location = new System.Drawing.Point(71, 51);
            this.PositionNameBox.Name = "PositionNameBox";
            this.PositionNameBox.Size = new System.Drawing.Size(262, 22);
            this.PositionNameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description: ";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(105, 94);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(228, 96);
            this.DescriptionTextBox.TabIndex = 5;
            this.DescriptionTextBox.Text = "";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(658, 374);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 64);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SavePositionButton
            // 
            this.SavePositionButton.Location = new System.Drawing.Point(658, 304);
            this.SavePositionButton.Name = "SavePositionButton";
            this.SavePositionButton.Size = new System.Drawing.Size(130, 64);
            this.SavePositionButton.TabIndex = 7;
            this.SavePositionButton.Text = "Save Position";
            this.SavePositionButton.UseVisualStyleBackColor = true;
            this.SavePositionButton.Click += new System.EventHandler(this.SavePositionButton_Click);
            // 
            // NewPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SavePositionButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PositionNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PositionIDTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NewPosition";
            this.Text = "NewPosition";
            this.Load += new System.EventHandler(this.NewPosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PositionIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PositionNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SavePositionButton;
    }
}