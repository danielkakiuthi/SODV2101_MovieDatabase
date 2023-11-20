namespace MovieDatabase {
    partial class FormUserRegister {
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
        private void InitializeComponent() {
            labelHeader_UserRegister = new Label();
            groupBox_UserRegister = new GroupBox();
            comboBoxCountry_Register = new ComboBox();
            dateTimePickerDateBirth_Register = new DateTimePicker();
            buttonCancel_Register = new Button();
            labelCountry_Register = new Label();
            labelDateBirth_Register = new Label();
            textBoxLastName_Register = new TextBox();
            labelLastName_Register = new Label();
            textBoxFirstName_Register = new TextBox();
            labelFirstName_Register = new Label();
            textBoxEmail_Register = new TextBox();
            textBoxPassword_Register = new TextBox();
            labelPassword_Register = new Label();
            buttonRegister_Register = new Button();
            labelEmail_Register = new Label();
            groupBox_UserRegister.SuspendLayout();
            SuspendLayout();
            // 
            // labelHeader_UserRegister
            // 
            labelHeader_UserRegister.AutoSize = true;
            labelHeader_UserRegister.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader_UserRegister.Location = new Point(12, 9);
            labelHeader_UserRegister.Name = "labelHeader_UserRegister";
            labelHeader_UserRegister.Size = new Size(188, 37);
            labelHeader_UserRegister.TabIndex = 1;
            labelHeader_UserRegister.Text = "User Register";
            // 
            // groupBox_UserRegister
            // 
            groupBox_UserRegister.BackColor = Color.White;
            groupBox_UserRegister.Controls.Add(comboBoxCountry_Register);
            groupBox_UserRegister.Controls.Add(dateTimePickerDateBirth_Register);
            groupBox_UserRegister.Controls.Add(buttonCancel_Register);
            groupBox_UserRegister.Controls.Add(labelCountry_Register);
            groupBox_UserRegister.Controls.Add(labelDateBirth_Register);
            groupBox_UserRegister.Controls.Add(textBoxLastName_Register);
            groupBox_UserRegister.Controls.Add(labelLastName_Register);
            groupBox_UserRegister.Controls.Add(textBoxFirstName_Register);
            groupBox_UserRegister.Controls.Add(labelFirstName_Register);
            groupBox_UserRegister.Controls.Add(textBoxEmail_Register);
            groupBox_UserRegister.Controls.Add(textBoxPassword_Register);
            groupBox_UserRegister.Controls.Add(labelPassword_Register);
            groupBox_UserRegister.Controls.Add(buttonRegister_Register);
            groupBox_UserRegister.Controls.Add(labelEmail_Register);
            groupBox_UserRegister.Location = new Point(38, 64);
            groupBox_UserRegister.Name = "groupBox_UserRegister";
            groupBox_UserRegister.Size = new Size(494, 491);
            groupBox_UserRegister.TabIndex = 2;
            groupBox_UserRegister.TabStop = false;
            groupBox_UserRegister.Text = "User Register";
            // 
            // comboBoxCountry_Register
            // 
            comboBoxCountry_Register.FormattingEnabled = true;
            comboBoxCountry_Register.ItemHeight = 21;
            comboBoxCountry_Register.Location = new Point(220, 301);
            comboBoxCountry_Register.Name = "comboBoxCountry_Register";
            comboBoxCountry_Register.Size = new Size(238, 29);
            comboBoxCountry_Register.TabIndex = 14;
            // 
            // dateTimePickerDateBirth_Register
            // 
            dateTimePickerDateBirth_Register.Location = new Point(220, 247);
            dateTimePickerDateBirth_Register.Name = "dateTimePickerDateBirth_Register";
            dateTimePickerDateBirth_Register.Size = new Size(238, 29);
            dateTimePickerDateBirth_Register.TabIndex = 12;
            // 
            // buttonCancel_Register
            // 
            buttonCancel_Register.BackColor = Color.FromArgb(192, 0, 0);
            buttonCancel_Register.Location = new Point(141, 417);
            buttonCancel_Register.Name = "buttonCancel_Register";
            buttonCancel_Register.Size = new Size(177, 40);
            buttonCancel_Register.TabIndex = 16;
            buttonCancel_Register.Text = "Cancel";
            buttonCancel_Register.UseVisualStyleBackColor = false;
            buttonCancel_Register.Click += buttonCancel_Register_Click;
            // 
            // labelCountry_Register
            // 
            labelCountry_Register.AutoSize = true;
            labelCountry_Register.Location = new Point(35, 301);
            labelCountry_Register.Name = "labelCountry_Register";
            labelCountry_Register.Size = new Size(90, 21);
            labelCountry_Register.TabIndex = 13;
            labelCountry_Register.Text = "Country (*):";
            // 
            // labelDateBirth_Register
            // 
            labelDateBirth_Register.AutoSize = true;
            labelDateBirth_Register.Location = new Point(35, 253);
            labelDateBirth_Register.Name = "labelDateBirth_Register";
            labelDateBirth_Register.Size = new Size(124, 21);
            labelDateBirth_Register.TabIndex = 11;
            labelDateBirth_Register.Text = "Date Of Birth (*):";
            // 
            // textBoxLastName_Register
            // 
            textBoxLastName_Register.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastName_Register.Location = new Point(220, 197);
            textBoxLastName_Register.Name = "textBoxLastName_Register";
            textBoxLastName_Register.Size = new Size(238, 29);
            textBoxLastName_Register.TabIndex = 10;
            // 
            // labelLastName_Register
            // 
            labelLastName_Register.AutoSize = true;
            labelLastName_Register.Location = new Point(35, 205);
            labelLastName_Register.Name = "labelLastName_Register";
            labelLastName_Register.Size = new Size(108, 21);
            labelLastName_Register.TabIndex = 9;
            labelLastName_Register.Text = "Last Name (*):";
            // 
            // textBoxFirstName_Register
            // 
            textBoxFirstName_Register.BorderStyle = BorderStyle.FixedSingle;
            textBoxFirstName_Register.Location = new Point(220, 151);
            textBoxFirstName_Register.Name = "textBoxFirstName_Register";
            textBoxFirstName_Register.Size = new Size(238, 29);
            textBoxFirstName_Register.TabIndex = 8;
            // 
            // labelFirstName_Register
            // 
            labelFirstName_Register.AutoSize = true;
            labelFirstName_Register.Location = new Point(35, 159);
            labelFirstName_Register.Name = "labelFirstName_Register";
            labelFirstName_Register.Size = new Size(110, 21);
            labelFirstName_Register.TabIndex = 7;
            labelFirstName_Register.Text = "First Name (*):";
            // 
            // textBoxEmail_Register
            // 
            textBoxEmail_Register.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail_Register.Location = new Point(220, 56);
            textBoxEmail_Register.Name = "textBoxEmail_Register";
            textBoxEmail_Register.Size = new Size(238, 29);
            textBoxEmail_Register.TabIndex = 4;
            // 
            // textBoxPassword_Register
            // 
            textBoxPassword_Register.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword_Register.Location = new Point(220, 104);
            textBoxPassword_Register.Name = "textBoxPassword_Register";
            textBoxPassword_Register.PasswordChar = '*';
            textBoxPassword_Register.Size = new Size(238, 29);
            textBoxPassword_Register.TabIndex = 6;
            // 
            // labelPassword_Register
            // 
            labelPassword_Register.AutoSize = true;
            labelPassword_Register.Location = new Point(35, 112);
            labelPassword_Register.Name = "labelPassword_Register";
            labelPassword_Register.Size = new Size(100, 21);
            labelPassword_Register.TabIndex = 5;
            labelPassword_Register.Text = "Password (*):";
            // 
            // buttonRegister_Register
            // 
            buttonRegister_Register.BackColor = Color.Green;
            buttonRegister_Register.Location = new Point(141, 358);
            buttonRegister_Register.Name = "buttonRegister_Register";
            buttonRegister_Register.Size = new Size(177, 40);
            buttonRegister_Register.TabIndex = 15;
            buttonRegister_Register.Text = "Register";
            buttonRegister_Register.UseVisualStyleBackColor = false;
            buttonRegister_Register.Click += buttonRegister_Register_Click;
            // 
            // labelEmail_Register
            // 
            labelEmail_Register.AutoSize = true;
            labelEmail_Register.Location = new Point(35, 64);
            labelEmail_Register.Name = "labelEmail_Register";
            labelEmail_Register.Size = new Size(72, 21);
            labelEmail_Register.TabIndex = 3;
            labelEmail_Register.Text = "Email (*):";
            // 
            // FormUserRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 630);
            Controls.Add(groupBox_UserRegister);
            Controls.Add(labelHeader_UserRegister);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormUserRegister";
            Text = "[FormUserRegister]";
            groupBox_UserRegister.ResumeLayout(false);
            groupBox_UserRegister.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader_UserRegister;
        private GroupBox groupBox_UserRegister;
        private LinkLabel linkLabelRegister_Login;
        private Button buttonRegister_Register;
        private TextBox textBoxPassword_Login;
        private Label labelPassword_Login;
        private TextBox textBoxEmail_Login;
        private Label labelEmail_Register;
        private TextBox textBoxPassword_Register;
        private Label labelPassword_Register;
        private TextBox textBoxEmail_Register;
        private Label labelCountry_Register;
        private Label labelDateBirth_Register;
        private TextBox textBoxLastName_Register;
        private Label labelLastName_Register;
        private TextBox textBoxFirstName_Register;
        private Label labelFirstName_Register;
        private Button buttonCancel_Register;
        private DateTimePicker dateTimePickerDateBirth_Register;
        private ComboBox comboBoxCountry_Register;
    }
}