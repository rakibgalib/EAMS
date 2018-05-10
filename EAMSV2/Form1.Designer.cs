namespace EAMSV2
{
    partial class Form1
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
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nidTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.contactNumberlabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.nidCardLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(368, 169);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 24;
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Location = new System.Drawing.Point(368, 137);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactNumberTextBox.TabIndex = 23;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(368, 106);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 22;
            // 
            // nidTextBox
            // 
            this.nidTextBox.Location = new System.Drawing.Point(368, 42);
            this.nidTextBox.Name = "nidTextBox";
            this.nidTextBox.Size = new System.Drawing.Size(100, 20);
            this.nidTextBox.TabIndex = 20;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(368, 9);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeeNameTextBox.TabIndex = 19;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(259, 169);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 18;
            this.salaryLabel.Text = "Salary";
            // 
            // contactNumberlabel
            // 
            this.contactNumberlabel.AutoSize = true;
            this.contactNumberlabel.Location = new System.Drawing.Point(259, 137);
            this.contactNumberlabel.Name = "contactNumberlabel";
            this.contactNumberlabel.Size = new System.Drawing.Size(84, 13);
            this.contactNumberlabel.TabIndex = 17;
            this.contactNumberlabel.Text = "Contact Number";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(259, 109);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 16;
            this.addressLabel.Text = "Address";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(259, 76);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(30, 13);
            this.dobLabel.TabIndex = 15;
            this.dobLabel.Text = "DOB";
            // 
            // nidCardLabel
            // 
            this.nidCardLabel.AutoSize = true;
            this.nidCardLabel.Location = new System.Drawing.Point(259, 42);
            this.nidCardLabel.Name = "nidCardLabel";
            this.nidCardLabel.Size = new System.Drawing.Size(68, 13);
            this.nidCardLabel.TabIndex = 14;
            this.nidCardLabel.Text = "NID Card No";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(259, 9);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(84, 13);
            this.employeeNameLabel.TabIndex = 13;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Location = new System.Drawing.Point(368, 70);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dobDateTimePicker.TabIndex = 26;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(393, 207);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 367);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.contactNumberTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nidTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.contactNumberlabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.nidCardLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nidTextBox;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label contactNumberlabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label nidCardLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.Button saveButton;
    }
}

