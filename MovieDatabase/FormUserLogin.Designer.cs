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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserLogin));
            groupBox_UserLogin = new GroupBox();
            pictureBoxLogo_Login = new PictureBox();
            linkLabelRegister_UserLogin = new LinkLabel();
            buttonLogin_UserLogin = new Button();
            textBoxPassword_UserLogin = new TextBox();
            labelPassword_UserLogin = new Label();
            textBoxEmail_UserLogin = new TextBox();
            labelEmail_UserLogin = new Label();
            groupBox_UserLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_Login).BeginInit();
            SuspendLayout();
            // 
            // groupBox_UserLogin
            // 
            groupBox_UserLogin.BackColor = Color.White;
            groupBox_UserLogin.Controls.Add(pictureBoxLogo_Login);
            groupBox_UserLogin.Controls.Add(linkLabelRegister_UserLogin);
            groupBox_UserLogin.Controls.Add(buttonLogin_UserLogin);
            groupBox_UserLogin.Controls.Add(textBoxPassword_UserLogin);
            groupBox_UserLogin.Controls.Add(labelPassword_UserLogin);
            groupBox_UserLogin.Controls.Add(textBoxEmail_UserLogin);
            groupBox_UserLogin.Controls.Add(labelEmail_UserLogin);
            groupBox_UserLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_UserLogin.Location = new Point(227, 106);
            groupBox_UserLogin.Name = "groupBox_UserLogin";
            groupBox_UserLogin.Size = new Size(306, 438);
            groupBox_UserLogin.TabIndex = 2;
            groupBox_UserLogin.TabStop = false;
            // 
            // pictureBoxLogo_Login
            // 
            pictureBoxLogo_Login.BackColor = Color.Black;
            pictureBoxLogo_Login.Image = (Image)resources.GetObject("pictureBoxLogo_Login.Image");
            pictureBoxLogo_Login.Location = new Point(0, 0);
            pictureBoxLogo_Login.Name = "pictureBoxLogo_Login";
            pictureBoxLogo_Login.Size = new Size(306, 50);
            pictureBoxLogo_Login.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo_Login.TabIndex = 9;
            pictureBoxLogo_Login.TabStop = false;
            // 
            // linkLabelRegister_UserLogin
            // 
            linkLabelRegister_UserLogin.AutoSize = true;
            linkLabelRegister_UserLogin.Location = new Point(74, 349);
            linkLabelRegister_UserLogin.Name = "linkLabelRegister_UserLogin";
            linkLabelRegister_UserLogin.Size = new Size(149, 23);
            linkLabelRegister_UserLogin.TabIndex = 8;
            linkLabelRegister_UserLogin.TabStop = true;
            linkLabelRegister_UserLogin.Text = "Register New User";
            linkLabelRegister_UserLogin.LinkClicked += linkLabelRegister_UserLogin_LinkClicked;
            // 
            // buttonLogin_UserLogin
            // 
            buttonLogin_UserLogin.BackColor = Color.Green;
            buttonLogin_UserLogin.ForeColor = Color.White;
            buttonLogin_UserLogin.Location = new Point(60, 294);
            buttonLogin_UserLogin.Name = "buttonLogin_UserLogin";
            buttonLogin_UserLogin.Size = new Size(177, 40);
            buttonLogin_UserLogin.TabIndex = 7;
            buttonLogin_UserLogin.Text = "Login";
            buttonLogin_UserLogin.UseVisualStyleBackColor = false;
            buttonLogin_UserLogin.Click += buttonLogin_UserLogin_Click;
            // 
            // textBoxPassword_UserLogin
            // 
            textBoxPassword_UserLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword_UserLogin.Location = new Point(34, 233);
            textBoxPassword_UserLogin.Name = "textBoxPassword_UserLogin";
            textBoxPassword_UserLogin.PasswordChar = '*';
            textBoxPassword_UserLogin.Size = new Size(238, 30);
            textBoxPassword_UserLogin.TabIndex = 6;
            // 
            // labelPassword_UserLogin
            // 
            labelPassword_UserLogin.AutoSize = true;
            labelPassword_UserLogin.Location = new Point(34, 197);
            labelPassword_UserLogin.Name = "labelPassword_UserLogin";
            labelPassword_UserLogin.Size = new Size(81, 23);
            labelPassword_UserLogin.TabIndex = 5;
            labelPassword_UserLogin.Text = "Password:";
            // 
            // textBoxEmail_UserLogin
            // 
            textBoxEmail_UserLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail_UserLogin.Location = new Point(34, 135);
            textBoxEmail_UserLogin.Name = "textBoxEmail_UserLogin";
            textBoxEmail_UserLogin.Size = new Size(238, 30);
            textBoxEmail_UserLogin.TabIndex = 4;
            // 
            // labelEmail_UserLogin
            // 
            labelEmail_UserLogin.AutoSize = true;
            labelEmail_UserLogin.Location = new Point(34, 99);
            labelEmail_UserLogin.Name = "labelEmail_UserLogin";
            labelEmail_UserLogin.Size = new Size(54, 23);
            labelEmail_UserLogin.TabIndex = 3;
            labelEmail_UserLogin.Text = "Email:";
            // 
            // FormUserLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.OIG__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 661);
            Controls.Add(groupBox_UserLogin);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormUserLogin";
            Text = "[FormUserLogin]";
            Load += FormUserLogin_Load;
            groupBox_UserLogin.ResumeLayout(false);
            groupBox_UserLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_Login).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox_UserLogin;
        private LinkLabel linkLabelRegister_UserLogin;
        private Button buttonLogin_UserLogin;
        private TextBox textBoxPassword_UserLogin;
        private Label labelPassword_UserLogin;
        private TextBox textBoxEmail_UserLogin;
        private Label labelEmail_UserLogin;
        private PictureBox pictureBoxLogo_Login;
    }
}