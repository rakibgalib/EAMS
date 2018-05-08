namespace EmployeeAttandanceManagement.View
{
    partial class employeeEntryForm
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
            this.employeeNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.employeeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.nidLabel = new MetroFramework.Controls.MetroLabel();
            this.nidCardTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(172, 80);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(207, 23);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(59, 80);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(107, 19);
            this.employeeNameLabel.TabIndex = 2;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // nidLabel
            // 
            this.nidLabel.AutoSize = true;
            this.nidLabel.Location = new System.Drawing.Point(69, 126);
            this.nidLabel.Name = "nidLabel";
            this.nidLabel.Size = new System.Drawing.Size(89, 19);
            this.nidLabel.TabIndex = 3;
            this.nidLabel.Text = "NID Card No:";
            // 
            // nidCardTextBox
            // 
            this.nidCardTextBox.Location = new System.Drawing.Point(172, 126);
            this.nidCardTextBox.Name = "nidCardTextBox";
            this.nidCardTextBox.Size = new System.Drawing.Size(207, 23);
            this.nidCardTextBox.TabIndex = 4;
            // 
            // employeeEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 360);
            this.Controls.Add(this.nidCardTextBox);
            this.Controls.Add(this.nidLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.employeeNameTextBox);
            this.Name = "employeeEntryForm";
            this.Text = "Employee Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox employeeNameTextBox;
        private MetroFramework.Controls.MetroLabel employeeNameLabel;
        private MetroFramework.Controls.MetroLabel nidLabel;
        private MetroFramework.Controls.MetroTextBox nidCardTextBox;
    }
}