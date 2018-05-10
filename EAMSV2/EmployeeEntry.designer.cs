namespace EmployeeAttandanceManagement.View
{
    partial class EmployeeEntry
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
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.nidCardLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactNumberlabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.nidTextBox = new System.Windows.Forms.TextBox();
            this.dobTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(22, 21);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(84, 13);
            this.employeeNameLabel.TabIndex = 0;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // nidCardLabel
            // 
            this.nidCardLabel.AutoSize = true;
            this.nidCardLabel.Location = new System.Drawing.Point(22, 54);
            this.nidCardLabel.Name = "nidCardLabel";
            this.nidCardLabel.Size = new System.Drawing.Size(68, 13);
            this.nidCardLabel.TabIndex = 1;
            this.nidCardLabel.Text = "NID Card No";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(22, 88);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(30, 13);
            this.dobLabel.TabIndex = 2;
            this.dobLabel.Text = "DOB";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(22, 289);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address";
            // 
            // contactNumberlabel
            // 
            this.contactNumberlabel.AutoSize = true;
            this.contactNumberlabel.Location = new System.Drawing.Point(22, 317);
            this.contactNumberlabel.Name = "contactNumberlabel";
            this.contactNumberlabel.Size = new System.Drawing.Size(84, 13);
            this.contactNumberlabel.TabIndex = 4;
            this.contactNumberlabel.Text = "Contact Number";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(22, 349);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 5;
            this.salaryLabel.Text = "Salary";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(131, 21);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeeNameTextBox.TabIndex = 6;
            // 
            // nidTextBox
            // 
            this.nidTextBox.Location = new System.Drawing.Point(131, 54);
            this.nidTextBox.Name = "nidTextBox";
            this.nidTextBox.Size = new System.Drawing.Size(100, 20);
            this.nidTextBox.TabIndex = 7;
            // 
            // dobTextBox
            // 
            this.dobTextBox.Location = new System.Drawing.Point(131, 88);
            this.dobTextBox.Name = "dobTextBox";
            this.dobTextBox.Size = new System.Drawing.Size(100, 20);
            this.dobTextBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(131, 286);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 9;
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Location = new System.Drawing.Point(131, 317);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactNumberTextBox.TabIndex = 10;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(131, 349);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 11;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(131, 112);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 12;
            // 
            // EmployeeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 413);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.contactNumberTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.dobTextBox);
            this.Controls.Add(this.nidTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.contactNumberlabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.nidCardLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Name = "EmployeeEntry";
            this.Text = "EmployeeEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label nidCardLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label contactNumberlabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox nidTextBox;
        private System.Windows.Forms.TextBox dobTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}