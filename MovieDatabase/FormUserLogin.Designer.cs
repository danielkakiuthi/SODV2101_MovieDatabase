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
            SuspendLayout();
            // 
            // labelHeader_UserLogin
            // 
            labelHeader_UserLogin.AutoSize = true;
            labelHeader_UserLogin.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader_UserLogin.Location = new Point(12, 9);
            labelHeader_UserLogin.Name = "labelHeader_UserLogin";
            labelHeader_UserLogin.Size = new Size(154, 37);
            labelHeader_UserLogin.TabIndex = 22;
            labelHeader_UserLogin.Text = "User Login";
            // 
            // FormUserLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(labelHeader_UserLogin);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormUserLogin";
            Text = "[FormUserLogin]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader_UserLogin;
    }
}