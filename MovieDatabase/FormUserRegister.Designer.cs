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
            SuspendLayout();
            // 
            // labelHeader_UserRegister
            // 
            labelHeader_UserRegister.AutoSize = true;
            labelHeader_UserRegister.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader_UserRegister.Location = new Point(12, 9);
            labelHeader_UserRegister.Name = "labelHeader_UserRegister";
            labelHeader_UserRegister.Size = new Size(188, 37);
            labelHeader_UserRegister.TabIndex = 23;
            labelHeader_UserRegister.Text = "User Register";
            // 
            // FormRegisterUser
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(labelHeader_UserRegister);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormRegisterUser";
            Text = "[FormUserRegister]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader_UserRegister;
    }
}