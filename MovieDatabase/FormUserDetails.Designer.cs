namespace MovieDatabase {
    partial class FormUserDetails {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            labelHeader_UserDetails = new Label();
            groupBox_UserDetails = new GroupBox();
            comboBoxCountry_UserDetails = new ComboBox();
            dateTimePickerDateBirth_UserDetails = new DateTimePicker();
            buttonCancel_UserDetails = new Button();
            labelCountry_UserDetails = new Label();
            labelDateBirth_UserDetails = new Label();
            textBoxLastName_UserDetails = new TextBox();
            labelLastName_UserDetails = new Label();
            textBoxFirstName_UserDetails = new TextBox();
            labelFirstName_UserDetails = new Label();
            textBoxEmail_UserDetails = new TextBox();
            textBoxPassword_UserDetails = new TextBox();
            labelPassword_UserDetails = new Label();
            buttonUpdate_UserDetails = new Button();
            labelEmail_UserDetails = new Label();
            groupBox_UserDetails.SuspendLayout();
            SuspendLayout();
            // 
            // labelHeader_UserDetails
            // 
            labelHeader_UserDetails.AutoSize = true;
            labelHeader_UserDetails.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader_UserDetails.ForeColor = Color.White;
            labelHeader_UserDetails.Location = new Point(12, 9);
            labelHeader_UserDetails.Name = "labelHeader_UserDetails";
            labelHeader_UserDetails.Size = new Size(171, 37);
            labelHeader_UserDetails.TabIndex = 22;
            labelHeader_UserDetails.Text = "User Details";
            // 
            // groupBox_UserDetails
            // 
            groupBox_UserDetails.BackColor = Color.White;
            groupBox_UserDetails.Controls.Add(comboBoxCountry_UserDetails);
            groupBox_UserDetails.Controls.Add(dateTimePickerDateBirth_UserDetails);
            groupBox_UserDetails.Controls.Add(buttonCancel_UserDetails);
            groupBox_UserDetails.Controls.Add(labelCountry_UserDetails);
            groupBox_UserDetails.Controls.Add(labelDateBirth_UserDetails);
            groupBox_UserDetails.Controls.Add(textBoxLastName_UserDetails);
            groupBox_UserDetails.Controls.Add(labelLastName_UserDetails);
            groupBox_UserDetails.Controls.Add(textBoxFirstName_UserDetails);
            groupBox_UserDetails.Controls.Add(labelFirstName_UserDetails);
            groupBox_UserDetails.Controls.Add(textBoxEmail_UserDetails);
            groupBox_UserDetails.Controls.Add(textBoxPassword_UserDetails);
            groupBox_UserDetails.Controls.Add(labelPassword_UserDetails);
            groupBox_UserDetails.Controls.Add(buttonUpdate_UserDetails);
            groupBox_UserDetails.Controls.Add(labelEmail_UserDetails);
            groupBox_UserDetails.Location = new Point(404, 94);
            groupBox_UserDetails.Name = "groupBox_UserDetails";
            groupBox_UserDetails.Size = new Size(494, 491);
            groupBox_UserDetails.TabIndex = 23;
            groupBox_UserDetails.TabStop = false;
            groupBox_UserDetails.Text = "User Details";
            // 
            // comboBoxCountry_UserDetails
            // 
            comboBoxCountry_UserDetails.FormattingEnabled = true;
            comboBoxCountry_UserDetails.ItemHeight = 15;
            comboBoxCountry_UserDetails.Location = new Point(220, 301);
            comboBoxCountry_UserDetails.Name = "comboBoxCountry_UserDetails";
            comboBoxCountry_UserDetails.Size = new Size(238, 23);
            comboBoxCountry_UserDetails.TabIndex = 14;
            // 
            // dateTimePickerDateBirth_UserDetails
            // 
            dateTimePickerDateBirth_UserDetails.Location = new Point(220, 247);
            dateTimePickerDateBirth_UserDetails.Name = "dateTimePickerDateBirth_UserDetails";
            dateTimePickerDateBirth_UserDetails.Size = new Size(238, 23);
            dateTimePickerDateBirth_UserDetails.TabIndex = 12;
            // 
            // buttonCancel_UserDetails
            // 
            buttonCancel_UserDetails.BackColor = Color.FromArgb(192, 0, 0);
            buttonCancel_UserDetails.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel_UserDetails.ForeColor = Color.White;
            buttonCancel_UserDetails.Location = new Point(141, 417);
            buttonCancel_UserDetails.Name = "buttonCancel_UserDetails";
            buttonCancel_UserDetails.Size = new Size(177, 40);
            buttonCancel_UserDetails.TabIndex = 16;
            buttonCancel_UserDetails.Text = "Cancel";
            buttonCancel_UserDetails.UseVisualStyleBackColor = false;
            buttonCancel_UserDetails.Click += buttonCancel_UserDetails_Click;
            // 
            // labelCountry_UserDetails
            // 
            labelCountry_UserDetails.AutoSize = true;
            labelCountry_UserDetails.Location = new Point(35, 301);
            labelCountry_UserDetails.Name = "labelCountry_UserDetails";
            labelCountry_UserDetails.Size = new Size(53, 15);
            labelCountry_UserDetails.TabIndex = 13;
            labelCountry_UserDetails.Text = "Country:";
            // 
            // labelDateBirth_UserDetails
            // 
            labelDateBirth_UserDetails.AutoSize = true;
            labelDateBirth_UserDetails.Location = new Point(35, 253);
            labelDateBirth_UserDetails.Name = "labelDateBirth_UserDetails";
            labelDateBirth_UserDetails.Size = new Size(78, 15);
            labelDateBirth_UserDetails.TabIndex = 11;
            labelDateBirth_UserDetails.Text = "Date Of Birth:";
            // 
            // textBoxLastName_UserDetails
            // 
            textBoxLastName_UserDetails.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastName_UserDetails.Location = new Point(220, 197);
            textBoxLastName_UserDetails.Name = "textBoxLastName_UserDetails";
            textBoxLastName_UserDetails.Size = new Size(238, 23);
            textBoxLastName_UserDetails.TabIndex = 10;
            // 
            // labelLastName_UserDetails
            // 
            labelLastName_UserDetails.AutoSize = true;
            labelLastName_UserDetails.Location = new Point(35, 205);
            labelLastName_UserDetails.Name = "labelLastName_UserDetails";
            labelLastName_UserDetails.Size = new Size(66, 15);
            labelLastName_UserDetails.TabIndex = 9;
            labelLastName_UserDetails.Text = "Last Name:";
            // 
            // textBoxFirstName_UserDetails
            // 
            textBoxFirstName_UserDetails.BorderStyle = BorderStyle.FixedSingle;
            textBoxFirstName_UserDetails.Location = new Point(220, 151);
            textBoxFirstName_UserDetails.Name = "textBoxFirstName_UserDetails";
            textBoxFirstName_UserDetails.Size = new Size(238, 23);
            textBoxFirstName_UserDetails.TabIndex = 8;
            // 
            // labelFirstName_UserDetails
            // 
            labelFirstName_UserDetails.AutoSize = true;
            labelFirstName_UserDetails.Location = new Point(35, 159);
            labelFirstName_UserDetails.Name = "labelFirstName_UserDetails";
            labelFirstName_UserDetails.Size = new Size(67, 15);
            labelFirstName_UserDetails.TabIndex = 7;
            labelFirstName_UserDetails.Text = "First Name:";
            // 
            // textBoxEmail_UserDetails
            // 
            textBoxEmail_UserDetails.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail_UserDetails.Location = new Point(220, 56);
            textBoxEmail_UserDetails.Name = "textBoxEmail_UserDetails";
            textBoxEmail_UserDetails.Size = new Size(238, 23);
            textBoxEmail_UserDetails.TabIndex = 4;
            // 
            // textBoxPassword_UserDetails
            // 
            textBoxPassword_UserDetails.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword_UserDetails.Location = new Point(220, 104);
            textBoxPassword_UserDetails.Name = "textBoxPassword_UserDetails";
            textBoxPassword_UserDetails.PasswordChar = '*';
            textBoxPassword_UserDetails.Size = new Size(238, 23);
            textBoxPassword_UserDetails.TabIndex = 6;
            // 
            // labelPassword_UserDetails
            // 
            labelPassword_UserDetails.AutoSize = true;
            labelPassword_UserDetails.Location = new Point(35, 112);
            labelPassword_UserDetails.Name = "labelPassword_UserDetails";
            labelPassword_UserDetails.Size = new Size(60, 15);
            labelPassword_UserDetails.TabIndex = 5;
            labelPassword_UserDetails.Text = "Password:";
            // 
            // buttonUpdate_UserDetails
            // 
            buttonUpdate_UserDetails.BackColor = Color.Green;
            buttonUpdate_UserDetails.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate_UserDetails.ForeColor = Color.White;
            buttonUpdate_UserDetails.Location = new Point(141, 358);
            buttonUpdate_UserDetails.Name = "buttonUpdate_UserDetails";
            buttonUpdate_UserDetails.Size = new Size(177, 40);
            buttonUpdate_UserDetails.TabIndex = 15;
            buttonUpdate_UserDetails.Text = "Update";
            buttonUpdate_UserDetails.UseVisualStyleBackColor = false;
            buttonUpdate_UserDetails.Click += buttonUpdate_UserDetails_Click;
            // 
            // labelEmail_UserDetails
            // 
            labelEmail_UserDetails.AutoSize = true;
            labelEmail_UserDetails.Location = new Point(35, 64);
            labelEmail_UserDetails.Name = "labelEmail_UserDetails";
            labelEmail_UserDetails.Size = new Size(39, 15);
            labelEmail_UserDetails.TabIndex = 3;
            labelEmail_UserDetails.Text = "Email:";
            // 
            // FormUserDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1184, 661);
            Controls.Add(groupBox_UserDetails);
            Controls.Add(labelHeader_UserDetails);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormUserDetails";
            Text = "[FormUserDetails]";
            Load += FormUserDetails_Load;
            Paint += FormUserDetails_Paint;
            groupBox_UserDetails.ResumeLayout(false);
            groupBox_UserDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader_UserDetails;
        private GroupBox groupBox_UserDetails;
        private ComboBox comboBoxCountry_UserDetails;
        private DateTimePicker dateTimePickerDateBirth_UserDetails;
        private Button buttonCancel_UserDetails;
        private Label labelCountry_UserDetails;
        private Label labelDateBirth_UserDetails;
        private TextBox textBoxLastName_UserDetails;
        private Label labelLastName_UserDetails;
        private TextBox textBoxFirstName_UserDetails;
        private Label labelFirstName_UserDetails;
        private TextBox textBoxEmail_UserDetails;
        private TextBox textBoxPassword_UserDetails;
        private Label labelPassword_UserDetails;
        private Button buttonUpdate_UserDetails;
        private Label labelEmail_UserDetails;
    }
}