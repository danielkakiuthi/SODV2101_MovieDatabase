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
        private void InitializeComponent() {
            labelHeader_UserDetails = new Label();
            SuspendLayout();
            // 
            // labelHeader_UserDetails
            // 
            labelHeader_UserDetails.AutoSize = true;
            labelHeader_UserDetails.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader_UserDetails.Location = new Point(12, 9);
            labelHeader_UserDetails.Name = "labelHeader_UserDetails";
            labelHeader_UserDetails.Size = new Size(171, 37);
            labelHeader_UserDetails.TabIndex = 22;
            labelHeader_UserDetails.Text = "User Details";
            // 
            // FormUserDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelHeader_UserDetails);
            Name = "FormUserDetails";
            Text = "[FormUserDetails]";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader_UserDetails;
    }
}