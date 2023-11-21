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
            comboBoxCountry_UserRegister = new ComboBox();
            dateTimePickerDateBirth_UserRegister = new DateTimePicker();
            buttonCancel_UserRegister = new Button();
            labelCountry_UserRegister = new Label();
            labelDateBirth_UserRegister = new Label();
            textBoxLastName_UserRegister = new TextBox();
            labelLastName_UserRegister = new Label();
            textBoxFirstName_UserRegister = new TextBox();
            labelFirstName_UserRegister = new Label();
            textBoxEmail_UserRegister = new TextBox();
            textBoxPassword_UserRegister = new TextBox();
            labelPassword_UserRegister = new Label();
            buttonRegister_UserRegister = new Button();
            labelEmail_UserRegister = new Label();
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
            groupBox_UserRegister.Controls.Add(comboBoxCountry_UserRegister);
            groupBox_UserRegister.Controls.Add(dateTimePickerDateBirth_UserRegister);
            groupBox_UserRegister.Controls.Add(buttonCancel_UserRegister);
            groupBox_UserRegister.Controls.Add(labelCountry_UserRegister);
            groupBox_UserRegister.Controls.Add(labelDateBirth_UserRegister);
            groupBox_UserRegister.Controls.Add(textBoxLastName_UserRegister);
            groupBox_UserRegister.Controls.Add(labelLastName_UserRegister);
            groupBox_UserRegister.Controls.Add(textBoxFirstName_UserRegister);
            groupBox_UserRegister.Controls.Add(labelFirstName_UserRegister);
            groupBox_UserRegister.Controls.Add(textBoxEmail_UserRegister);
            groupBox_UserRegister.Controls.Add(textBoxPassword_UserRegister);
            groupBox_UserRegister.Controls.Add(labelPassword_UserRegister);
            groupBox_UserRegister.Controls.Add(buttonRegister_UserRegister);
            groupBox_UserRegister.Controls.Add(labelEmail_UserRegister);
            groupBox_UserRegister.Location = new Point(38, 64);
            groupBox_UserRegister.Name = "groupBox_UserRegister";
            groupBox_UserRegister.Size = new Size(494, 491);
            groupBox_UserRegister.TabIndex = 2;
            groupBox_UserRegister.TabStop = false;
            groupBox_UserRegister.Text = "User Register";
            // 
            // comboBoxCountry_UserRegister
            // 
            comboBoxCountry_UserRegister.FormattingEnabled = true;
            comboBoxCountry_UserRegister.ItemHeight = 21;
            comboBoxCountry_UserRegister.Location = new Point(220, 301);
            comboBoxCountry_UserRegister.Name = "comboBoxCountry_UserRegister";
            comboBoxCountry_UserRegister.Size = new Size(238, 29);
            comboBoxCountry_UserRegister.TabIndex = 14;
            // 
            // dateTimePickerDateBirth_UserRegister
            // 
            dateTimePickerDateBirth_UserRegister.Location = new Point(220, 247);
            dateTimePickerDateBirth_UserRegister.Name = "dateTimePickerDateBirth_UserRegister";
            dateTimePickerDateBirth_UserRegister.Size = new Size(238, 29);
            dateTimePickerDateBirth_UserRegister.TabIndex = 12;
            // 
            // buttonCancel_UserRegister
            // 
            buttonCancel_UserRegister.BackColor = Color.FromArgb(192, 0, 0);
            buttonCancel_UserRegister.Location = new Point(141, 417);
            buttonCancel_UserRegister.Name = "buttonCancel_UserRegister";
            buttonCancel_UserRegister.Size = new Size(177, 40);
            buttonCancel_UserRegister.TabIndex = 16;
            buttonCancel_UserRegister.Text = "Cancel";
            buttonCancel_UserRegister.UseVisualStyleBackColor = false;
            buttonCancel_UserRegister.Click += buttonCancel_Register_Click;
            // 
            // labelCountry_UserRegister
            // 
            labelCountry_UserRegister.AutoSize = true;
            labelCountry_UserRegister.Location = new Point(35, 301);
            labelCountry_UserRegister.Name = "labelCountry_UserRegister";
            labelCountry_UserRegister.Size = new Size(90, 21);
            labelCountry_UserRegister.TabIndex = 13;
            labelCountry_UserRegister.Text = "Country (*):";
            // 
            // labelDateBirth_UserRegister
            // 
            labelDateBirth_UserRegister.AutoSize = true;
            labelDateBirth_UserRegister.Location = new Point(35, 253);
            labelDateBirth_UserRegister.Name = "labelDateBirth_UserRegister";
            labelDateBirth_UserRegister.Size = new Size(124, 21);
            labelDateBirth_UserRegister.TabIndex = 11;
            labelDateBirth_UserRegister.Text = "Date Of Birth (*):";
            // 
            // textBoxLastName_UserRegister
            // 
            textBoxLastName_UserRegister.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastName_UserRegister.Location = new Point(220, 197);
            textBoxLastName_UserRegister.Name = "textBoxLastName_UserRegister";
            textBoxLastName_UserRegister.Size = new Size(238, 29);
            textBoxLastName_UserRegister.TabIndex = 10;
            // 
            // labelLastName_UserRegister
            // 
            labelLastName_UserRegister.AutoSize = true;
            labelLastName_UserRegister.Location = new Point(35, 205);
            labelLastName_UserRegister.Name = "labelLastName_UserRegister";
            labelLastName_UserRegister.Size = new Size(108, 21);
            labelLastName_UserRegister.TabIndex = 9;
            labelLastName_UserRegister.Text = "Last Name (*):";
            // 
            // textBoxFirstName_UserRegister
            // 
            textBoxFirstName_UserRegister.BorderStyle = BorderStyle.FixedSingle;
            textBoxFirstName_UserRegister.Location = new Point(220, 151);
            textBoxFirstName_UserRegister.Name = "textBoxFirstName_UserRegister";
            textBoxFirstName_UserRegister.Size = new Size(238, 29);
            textBoxFirstName_UserRegister.TabIndex = 8;
            // 
            // labelFirstName_UserRegister
            // 
            labelFirstName_UserRegister.AutoSize = true;
            labelFirstName_UserRegister.Location = new Point(35, 159);
            labelFirstName_UserRegister.Name = "labelFirstName_UserRegister";
            labelFirstName_UserRegister.Size = new Size(110, 21);
            labelFirstName_UserRegister.TabIndex = 7;
            labelFirstName_UserRegister.Text = "First Name (*):";
            // 
            // textBoxEmail_UserRegister
            // 
            textBoxEmail_UserRegister.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail_UserRegister.Location = new Point(220, 56);
            textBoxEmail_UserRegister.Name = "textBoxEmail_UserRegister";
            textBoxEmail_UserRegister.Size = new Size(238, 29);
            textBoxEmail_UserRegister.TabIndex = 4;
            // 
            // textBoxPassword_UserRegister
            // 
            textBoxPassword_UserRegister.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword_UserRegister.Location = new Point(220, 104);
            textBoxPassword_UserRegister.Name = "textBoxPassword_UserRegister";
            textBoxPassword_UserRegister.PasswordChar = '*';
            textBoxPassword_UserRegister.Size = new Size(238, 29);
            textBoxPassword_UserRegister.TabIndex = 6;
            // 
            // labelPassword_UserRegister
            // 
            labelPassword_UserRegister.AutoSize = true;
            labelPassword_UserRegister.Location = new Point(35, 112);
            labelPassword_UserRegister.Name = "labelPassword_UserRegister";
            labelPassword_UserRegister.Size = new Size(100, 21);
            labelPassword_UserRegister.TabIndex = 5;
            labelPassword_UserRegister.Text = "Password (*):";
            // 
            // buttonRegister_UserRegister
            // 
            buttonRegister_UserRegister.BackColor = Color.Green;
            buttonRegister_UserRegister.Location = new Point(141, 358);
            buttonRegister_UserRegister.Name = "buttonRegister_UserRegister";
            buttonRegister_UserRegister.Size = new Size(177, 40);
            buttonRegister_UserRegister.TabIndex = 15;
            buttonRegister_UserRegister.Text = "Register";
            buttonRegister_UserRegister.UseVisualStyleBackColor = false;
            buttonRegister_UserRegister.Click += buttonRegister_Register_Click;
            // 
            // labelEmail_UserRegister
            // 
            labelEmail_UserRegister.AutoSize = true;
            labelEmail_UserRegister.Location = new Point(35, 64);
            labelEmail_UserRegister.Name = "labelEmail_UserRegister";
            labelEmail_UserRegister.Size = new Size(72, 21);
            labelEmail_UserRegister.TabIndex = 3;
            labelEmail_UserRegister.Text = "Email (*):";
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
        private Button buttonRegister_UserRegister;
        private TextBox textBoxPassword_Login;
        private Label labelPassword_Login;
        private TextBox textBoxEmail_Login;
        private Label labelEmail_UserRegister;
        private TextBox textBoxPassword_UserRegister;
        private Label labelPassword_UserRegister;
        private TextBox textBoxEmail_UserRegister;
        private Label labelCountry_UserRegister;
        private Label labelDateBirth_UserRegister;
        private TextBox textBoxLastName_UserRegister;
        private Label labelLastName_UserRegister;
        private TextBox textBoxFirstName_UserRegister;
        private Label labelFirstName_UserRegister;
        private Button buttonCancel_UserRegister;
        private DateTimePicker dateTimePickerDateBirth_UserRegister;
        private ComboBox comboBoxCountry_UserRegister;
    }
}