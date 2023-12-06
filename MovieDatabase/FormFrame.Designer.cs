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
            pictureBoxLogo = new PictureBox();
            buttonFavoriteDetails_Frame = new Button();
            labelHeader_Frame = new Label();
            buttonLogout_Frame = new Button();
            buttonTitleSearch_Frame = new Button();
            buttonUserDetails_Frame = new Button();
            buttonHomepage_Frame = new Button();
            tabControlContent_Frame = new TabControl();
            groupBoxMenu_Frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMenu_Frame
            // 
            groupBoxMenu_Frame.BackColor = Color.DarkSlateBlue;
            groupBoxMenu_Frame.Controls.Add(pictureBoxLogo);
            groupBoxMenu_Frame.Controls.Add(buttonFavoriteDetails_Frame);
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
            groupBoxMenu_Frame.Paint += groupBoxMenu_Frame_Paint;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(194, 50);
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonFavoriteDetails_Frame
            // 
            buttonFavoriteDetails_Frame.BackColor = Color.Indigo;
            buttonFavoriteDetails_Frame.ForeColor = Color.White;
            buttonFavoriteDetails_Frame.Image = Properties.Resources.IconTitleDetails1;
            buttonFavoriteDetails_Frame.Location = new Point(12, 248);
            buttonFavoriteDetails_Frame.Name = "buttonFavoriteDetails_Frame";
            buttonFavoriteDetails_Frame.Size = new Size(175, 36);
            buttonFavoriteDetails_Frame.TabIndex = 5;
            buttonFavoriteDetails_Frame.Text = "Favorites";
            buttonFavoriteDetails_Frame.TextAlign = ContentAlignment.MiddleRight;
            buttonFavoriteDetails_Frame.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFavoriteDetails_Frame.UseVisualStyleBackColor = false;
            buttonFavoriteDetails_Frame.Click += buttonFavoriteDetails_Frame_Click;
            // 
            // labelHeader_Frame
            // 
            labelHeader_Frame.AutoSize = true;
            labelHeader_Frame.BackColor = Color.Transparent;
            labelHeader_Frame.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeader_Frame.ForeColor = Color.White;
            labelHeader_Frame.Location = new Point(7, 53);
            labelHeader_Frame.Name = "labelHeader_Frame";
            labelHeader_Frame.Size = new Size(98, 27);
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
            buttonTitleSearch_Frame.BackColor = Color.Indigo;
            buttonTitleSearch_Frame.ForeColor = Color.White;
            buttonTitleSearch_Frame.Image = Properties.Resources.IconTestApi;
            buttonTitleSearch_Frame.Location = new Point(12, 206);
            buttonTitleSearch_Frame.Name = "buttonTitleSearch_Frame";
            buttonTitleSearch_Frame.Size = new Size(175, 36);
            buttonTitleSearch_Frame.TabIndex = 2;
            buttonTitleSearch_Frame.Text = "Title Search";
            buttonTitleSearch_Frame.TextAlign = ContentAlignment.MiddleRight;
            buttonTitleSearch_Frame.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonTitleSearch_Frame.UseVisualStyleBackColor = false;
            buttonTitleSearch_Frame.Click += buttonTitleSearch_Frame_Click;
            // 
            // buttonUserDetails_Frame
            // 
            buttonUserDetails_Frame.BackColor = Color.Indigo;
            buttonUserDetails_Frame.ForeColor = Color.White;
            buttonUserDetails_Frame.Image = Properties.Resources.IconAccount;
            buttonUserDetails_Frame.Location = new Point(12, 164);
            buttonUserDetails_Frame.Name = "buttonUserDetails_Frame";
            buttonUserDetails_Frame.Size = new Size(175, 36);
            buttonUserDetails_Frame.TabIndex = 1;
            buttonUserDetails_Frame.Text = "User Details";
            buttonUserDetails_Frame.TextAlign = ContentAlignment.MiddleRight;
            buttonUserDetails_Frame.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonUserDetails_Frame.UseVisualStyleBackColor = false;
            buttonUserDetails_Frame.Click += buttonUserDetails_Frame_Click;
            // 
            // buttonHomepage_Frame
            // 
            buttonHomepage_Frame.BackColor = Color.Indigo;
            buttonHomepage_Frame.ForeColor = Color.White;
            buttonHomepage_Frame.Image = Properties.Resources.IconHomepage;
            buttonHomepage_Frame.Location = new Point(12, 122);
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
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
        private Button buttonFavoriteDetails_Frame;
        private PictureBox pictureBoxLogo;
    }
}