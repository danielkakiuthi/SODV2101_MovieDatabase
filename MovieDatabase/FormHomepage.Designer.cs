﻿namespace MovieDatabase {
    partial class FormHomepage {
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
            labelHeader_Homepage = new Label();
            SuspendLayout();
            // 
            // labelHeader_Homepage
            // 
            labelHeader_Homepage.AutoSize = true;
            labelHeader_Homepage.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader_Homepage.Location = new Point(12, 9);
            labelHeader_Homepage.Name = "labelHeader_Homepage";
            labelHeader_Homepage.Size = new Size(159, 37);
            labelHeader_Homepage.TabIndex = 23;
            labelHeader_Homepage.Text = "Homepage";
            // 
            // FormHomepage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(labelHeader_Homepage);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormHomepage";
            Text = "[FormHomepage]";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader_Homepage;
    }
}