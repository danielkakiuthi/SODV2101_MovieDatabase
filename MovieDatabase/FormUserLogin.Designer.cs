namespace MovieDatabase {
    partial class FormUserLogin {
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
            labelHeader_UserLogin = new Label();
            groupBox_UserLogin = new GroupBox();
            linkLabelRegister_Login = new LinkLabel();
            buttonLogin_Login = new Button();
            textBoxPassword_Login = new TextBox();
            labelPassword_Login = new Label();
            textBoxEmail_Login = new TextBox();
            labelEmail_Login = new Label();
            groupBox_UserLogin.SuspendLayout();
            SuspendLayout();
            // 
            // labelHeader_UserLogin
            // 
            labelHeader_UserLogin.AutoSize = true;
            labelHeader_UserLogin.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader_UserLogin.Location = new Point(12, 9);
            labelHeader_UserLogin.Name = "labelHeader_UserLogin";
            labelHeader_UserLogin.Size = new Size(154, 37);
            labelHeader_UserLogin.TabIndex = 1;
            labelHeader_UserLogin.Text = "User Login";
            // 
            // groupBox_UserLogin
            // 
            groupBox_UserLogin.BackColor = Color.White;
            groupBox_UserLogin.Controls.Add(linkLabelRegister_Login);
            groupBox_UserLogin.Controls.Add(buttonLogin_Login);
            groupBox_UserLogin.Controls.Add(textBoxPassword_Login);
            groupBox_UserLogin.Controls.Add(labelPassword_Login);
            groupBox_UserLogin.Controls.Add(textBoxEmail_Login);
            groupBox_UserLogin.Controls.Add(labelEmail_Login);
            groupBox_UserLogin.Location = new Point(63, 129);
            groupBox_UserLogin.Name = "groupBox_UserLogin";
            groupBox_UserLogin.Size = new Size(306, 438);
            groupBox_UserLogin.TabIndex = 2;
            groupBox_UserLogin.TabStop = false;
            groupBox_UserLogin.Text = "User Login";
            // 
            // linkLabelRegister_Login
            // 
            linkLabelRegister_Login.AutoSize = true;
            linkLabelRegister_Login.Location = new Point(75, 314);
            linkLabelRegister_Login.Name = "linkLabelRegister_Login";
            linkLabelRegister_Login.Size = new Size(139, 21);
            linkLabelRegister_Login.TabIndex = 8;
            linkLabelRegister_Login.TabStop = true;
            linkLabelRegister_Login.Text = "Register New User";
            linkLabelRegister_Login.LinkClicked += linkLabelRegister_Login_LinkClicked;
            // 
            // buttonLogin_Login
            // 
            buttonLogin_Login.BackColor = Color.Green;
            buttonLogin_Login.Location = new Point(61, 259);
            buttonLogin_Login.Name = "buttonLogin_Login";
            buttonLogin_Login.Size = new Size(177, 40);
            buttonLogin_Login.TabIndex = 7;
            buttonLogin_Login.Text = "Login";
            buttonLogin_Login.UseVisualStyleBackColor = false;
            buttonLogin_Login.Click += buttonLogin_Login_Click;
            // 
            // textBoxPassword_Login
            // 
            textBoxPassword_Login.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword_Login.Location = new Point(35, 198);
            textBoxPassword_Login.Name = "textBoxPassword_Login";
            textBoxPassword_Login.PasswordChar = '*';
            textBoxPassword_Login.Size = new Size(238, 29);
            textBoxPassword_Login.TabIndex = 6;
            // 
            // labelPassword_Login
            // 
            labelPassword_Login.AutoSize = true;
            labelPassword_Login.Location = new Point(35, 162);
            labelPassword_Login.Name = "labelPassword_Login";
            labelPassword_Login.Size = new Size(79, 21);
            labelPassword_Login.TabIndex = 5;
            labelPassword_Login.Text = "Password:";
            // 
            // textBoxEmail_Login
            // 
            textBoxEmail_Login.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail_Login.Location = new Point(35, 100);
            textBoxEmail_Login.Name = "textBoxEmail_Login";
            textBoxEmail_Login.Size = new Size(238, 29);
            textBoxEmail_Login.TabIndex = 4;
            // 
            // labelEmail_Login
            // 
            labelEmail_Login.AutoSize = true;
            labelEmail_Login.Location = new Point(35, 64);
            labelEmail_Login.Name = "labelEmail_Login";
            labelEmail_Login.Size = new Size(51, 21);
            labelEmail_Login.TabIndex = 3;
            labelEmail_Login.Text = "Email:";
            // 
            // FormUserLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 661);
            Controls.Add(groupBox_UserLogin);
            Controls.Add(labelHeader_UserLogin);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormUserLogin";
            Text = "[FormUserLogin]";
            groupBox_UserLogin.ResumeLayout(false);
            groupBox_UserLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader_UserLogin;
        private GroupBox groupBox_UserLogin;
        private LinkLabel linkLabelRegister_Login;
        private Button buttonLogin_Login;
        private TextBox textBoxPassword_Login;
        private Label labelPassword_Login;
        private TextBox textBoxEmail_Login;
        private Label labelEmail_Login;
    }
}