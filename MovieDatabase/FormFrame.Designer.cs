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
            labelHeader_Frame = new Label();
            buttonLogout_Frame = new Button();
            buttonSearch_Frame = new Button();
            buttonUserDetails_Frame = new Button();
            buttonHomepage_Frame = new Button();
            tabControlContent_Frame = new TabControl();
            groupBoxMenu_Frame.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMenu_Frame
            // 
            groupBoxMenu_Frame.BackColor = SystemColors.ControlDarkDark;
            groupBoxMenu_Frame.Controls.Add(labelHeader_Frame);
            groupBoxMenu_Frame.Controls.Add(buttonLogout_Frame);
            groupBoxMenu_Frame.Controls.Add(buttonSearch_Frame);
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
            // buttonSearch_Frame
            // 
            buttonSearch_Frame.Image = Properties.Resources.IconTestApi;
            buttonSearch_Frame.Location = new Point(12, 158);
            buttonSearch_Frame.Name = "buttonSearch_Frame";
            buttonSearch_Frame.Size = new Size(175, 36);
            buttonSearch_Frame.TabIndex = 2;
            buttonSearch_Frame.Text = "Title Search";
            buttonSearch_Frame.TextAlign = ContentAlignment.MiddleRight;
            buttonSearch_Frame.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSearch_Frame.UseVisualStyleBackColor = true;
            buttonSearch_Frame.Click += buttonTitleSearch_Frame_Click;
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
            buttonHomepage_Frame.Image = Properties.Resources.IconHomepage;
            buttonHomepage_Frame.Location = new Point(12, 74);
            buttonHomepage_Frame.Name = "buttonHomepage_Frame";
            buttonHomepage_Frame.Size = new Size(175, 36);
            buttonHomepage_Frame.TabIndex = 0;
            buttonHomepage_Frame.Text = "Homepage";
            buttonHomepage_Frame.TextAlign = ContentAlignment.MiddleRight;
            buttonHomepage_Frame.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHomepage_Frame.UseVisualStyleBackColor = true;
            buttonHomepage_Frame.Click += buttonHomepage_Frame_Click;
            // 
            // tabControlContent_Frame
            // 
            tabControlContent_Frame.Location = new Point(193, 0);
            tabControlContent_Frame.Name = "tabControlContent_Frame";
            tabControlContent_Frame.SelectedIndex = 0;
            tabControlContent_Frame.Size = new Size(854, 629);
            tabControlContent_Frame.TabIndex = 0;
            tabControlContent_Frame.Visible = false;
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
        private Button buttonSearch_Frame;
        private Button buttonUserDetails_Frame;
        private TabControl tabControlContent_Frame;
        private Button buttonLogout_Frame;
        private Label labelHeader_Frame;
    }
}