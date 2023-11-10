namespace MovieDatabase {
    partial class FormTitleDetails {
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
            labelHeader_TitleDetails = new Label();
            SuspendLayout();
            // 
            // labelHeader_TitleDetails
            // 
            labelHeader_TitleDetails.AutoSize = true;
            labelHeader_TitleDetails.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader_TitleDetails.Location = new Point(12, 9);
            labelHeader_TitleDetails.Name = "labelHeader_TitleDetails";
            labelHeader_TitleDetails.Size = new Size(171, 37);
            labelHeader_TitleDetails.TabIndex = 22;
            labelHeader_TitleDetails.Text = "Title Details";
            // 
            // FormTitleDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(labelHeader_TitleDetails);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormTitleDetails";
            Text = "[FormTitleDetails]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader_TitleDetails;
    }
}