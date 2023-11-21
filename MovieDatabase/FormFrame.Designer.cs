namespace MovieDatabase {
    partial class FormFrame {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            groupBoxMenu_Frame = new GroupBox();
            buttonTitleDetails_Frame = new Button();
            labelHeader_Frame = new Label();
            buttonLogout_Frame = new Button();
            buttonTitleSearch_Frame = new Button();
            buttonUserDetails_Frame = new Button();
            buttonHomepage_Frame = new Button();
            tabControlContent_Frame = new TabControl();
            groupBoxMenu_Frame.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMenu_Frame
            // 
            groupBoxMenu_Frame.BackColor = SystemColors.ControlDarkDark;
            groupBoxMenu_Frame.Controls.Add(buttonTitleDetails_Frame);
            groupBoxMenu_Frame.Controls.Add(labelHeader_Frame);
            groupBoxMenu_Frame.Controls.Add(buttonLogout_Frame);
            groupBoxMenu_Frame.Controls.Add(buttonTitleSearch_Frame);
            groupBoxMenu_Frame.Controls.Add(buttonUserDetails_Frame);
            groupBoxMenu_Frame.Controls.Add(buttonHomepage_Frame);
            groupBoxMenu_Frame.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxMenu_Frame.Location = new Point(0, 0);
            groupBoxMenu_Frame.Margin = new Padding(4);
            groupBoxMenu_Frame.Name = "groupBoxMenu_Frame";
            groupBoxMenu_Frame.Padding = new Padding(4);
            groupBoxMenu_Frame.Size = new Size(194, 629);
            groupBoxMenu_Frame.TabIndex = 0;
            groupBoxMenu_Frame.TabStop = false;
            // 
            // buttonTitleDetails_Frame
            // 
            buttonTitleDetails_Frame.BackColor = SystemColors.GrayText;
            buttonTitleDetails_Frame.Image = Properties.Resources.IconTitleDetails1;
            buttonTitleDetails_Frame.Location = new Point(12, 200);
            buttonTitleDetails_Frame.Name = "buttonTitleDetails_Frame";
            buttonTitleDetails_Frame.Size = new Size(175, 36);
            buttonTitleDetails_Frame.TabIndex = 5;
            buttonTitleDetails_Frame.Text = "Title Details";
            buttonTitleDetails_Frame.TextAlign = ContentAlignment.MiddleRight;
            buttonTitleDetails_Frame.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonTitleDetails_Frame.UseVisualStyleBackColor = false;
            buttonTitleDetails_Frame.Click += buttonTitleDetails_Frame_Click;
            // 
            // labelHeader_Frame
            // 
            labelHeader_Frame.AutoSize = true;
            labelHeader_Frame.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelHeader_Frame.Location = new Point(12, 26);
            labelHeader_Frame.Name = "labelHeader_Frame";
            labelHeader_Frame.Size = new Size(77, 25);
            labelHeader_Frame.TabIndex = 4;
            labelHeader_Frame.Text = "Hello, ...";
            // 
            // buttonLogout_Frame
            // 
            buttonLogout_Frame.Image = Properties.Resources.IconLogin;
            buttonLogout_Frame.Location = new Point(7, 582);
            buttonLogout_Frame.Name = "buttonLogout_Frame";
            buttonLogout_Frame.Size = new Size(175, 36);
            buttonLogout_Frame.TabIndex = 3;
            buttonLogout_Frame.Text = "Logout";
            buttonLogout_Frame.TextAlign = ContentAlignment.MiddleRight;
            buttonLogout_Frame.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogout_Frame.UseVisualStyleBackColor = true;
            buttonLogout_Frame.Click += buttonLogout_Frame_Click;
            // 
            // buttonTitleSearch_Frame
            // 
            buttonTitleSearch_Frame.Image = Properties.Resources.IconTestApi;
            buttonTitleSearch_Frame.Location = new Point(12, 158);
            buttonTitleSearch_Frame.Name = "buttonTitleSearch_Frame";
            buttonTitleSearch_Frame.Size = new Size(175, 36);
            buttonTitleSearch_Frame.TabIndex = 2;
            buttonTitleSearch_Frame.Text = "Title Search";
            buttonTitleSearch_Frame.TextAlign = ContentAlignment.MiddleRight;
            buttonTitleSearch_Frame.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonTitleSearch_Frame.UseVisualStyleBackColor = true;
            buttonTitleSearch_Frame.Click += buttonTitleSearch_Frame_Click;
            // 
            // buttonUserDetails_Frame
            // 
            buttonUserDetails_Frame.Image = Properties.Resources.IconAccount;
            buttonUserDetails_Frame.Location = new Point(12, 116);
            buttonUserDetails_Frame.Name = "buttonUserDetails_Frame";
            buttonUserDetails_Frame.Size = new Size(175, 36);
            buttonUserDetails_Frame.TabIndex = 1;
            buttonUserDetails_Frame.Text = "User Details";
            buttonUserDetails_Frame.TextAlign = ContentAlignment.MiddleRight;
            buttonUserDetails_Frame.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonUserDetails_Frame.UseVisualStyleBackColor = true;
            buttonUserDetails_Frame.Click += buttonUserDetails_Frame_Click;
            // 
            // buttonHomepage_Frame
            // 
            buttonHomepage_Frame.BackColor = SystemColors.GrayText;
            buttonHomepage_Frame.Image = Properties.Resources.IconHomepage;
            buttonHomepage_Frame.Location = new Point(12, 74);
            buttonHomepage_Frame.Name = "buttonHomepage_Frame";
            buttonHomepage_Frame.Size = new Size(175, 36);
            buttonHomepage_Frame.TabIndex = 0;
            buttonHomepage_Frame.Text = "Homepage";
            buttonHomepage_Frame.TextAlign = ContentAlignment.MiddleRight;
            buttonHomepage_Frame.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHomepage_Frame.UseVisualStyleBackColor = false;
            buttonHomepage_Frame.Click += buttonHomepage_Frame_Click;
            // 
            // tabControlContent_Frame
            // 
            tabControlContent_Frame.Location = new Point(193, 0);
            tabControlContent_Frame.Name = "tabControlContent_Frame";
            tabControlContent_Frame.SelectedIndex = 0;
            tabControlContent_Frame.Size = new Size(854, 629);
            tabControlContent_Frame.TabIndex = 0;
            // 
            // FormFrame
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 630);
            Controls.Add(tabControlContent_Frame);
            Controls.Add(groupBoxMenu_Frame);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormFrame";
            Text = "[FormFrame] Landing Page";
            groupBoxMenu_Frame.ResumeLayout(false);
            groupBoxMenu_Frame.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMenu_Frame;
        private Button buttonHomepage_Frame;
        private Button buttonTitleSearch_Frame;
        private Button buttonUserDetails_Frame;
        private TabControl tabControlContent_Frame;
        private Button buttonLogout_Frame;
        private Label labelHeader_Frame;
        private Button buttonTitleDetails_Frame;
    }
}