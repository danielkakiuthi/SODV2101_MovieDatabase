namespace MovieDatabase {
    partial class FormMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxMenu_Main = new GroupBox();
            buttonUserLogin_Main = new Button();
            buttonSearch_Main = new Button();
            buttonUserDetails_Main = new Button();
            buttonHomepage_Main = new Button();
            tabControlContent_Main = new TabControl();
            groupBoxMenu_Main.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMenu_Main
            // 
            groupBoxMenu_Main.BackColor = SystemColors.ControlDarkDark;
            groupBoxMenu_Main.Controls.Add(buttonUserLogin_Main);
            groupBoxMenu_Main.Controls.Add(buttonSearch_Main);
            groupBoxMenu_Main.Controls.Add(buttonUserDetails_Main);
            groupBoxMenu_Main.Controls.Add(buttonHomepage_Main);
            groupBoxMenu_Main.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxMenu_Main.Location = new Point(0, 0);
            groupBoxMenu_Main.Margin = new Padding(4);
            groupBoxMenu_Main.Name = "groupBoxMenu_Main";
            groupBoxMenu_Main.Padding = new Padding(4);
            groupBoxMenu_Main.Size = new Size(194, 629);
            groupBoxMenu_Main.TabIndex = 0;
            groupBoxMenu_Main.TabStop = false;
            groupBoxMenu_Main.Text = "Menu";
            // 
            // buttonUserLogin_Main
            // 
            buttonUserLogin_Main.Image = (Image)resources.GetObject("buttonUserLogin_Main.Image");
            buttonUserLogin_Main.Location = new Point(7, 582);
            buttonUserLogin_Main.Name = "buttonUserLogin_Main";
            buttonUserLogin_Main.Size = new Size(175, 36);
            buttonUserLogin_Main.TabIndex = 3;
            buttonUserLogin_Main.Text = "User Login";
            buttonUserLogin_Main.TextAlign = ContentAlignment.MiddleRight;
            buttonUserLogin_Main.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonUserLogin_Main.UseVisualStyleBackColor = true;
            buttonUserLogin_Main.Click += buttonUserLogin_Click;
            // 
            // buttonSearch_Main
            // 
            buttonSearch_Main.Image = (Image)resources.GetObject("buttonSearch_Main.Image");
            buttonSearch_Main.Location = new Point(12, 113);
            buttonSearch_Main.Name = "buttonSearch_Main";
            buttonSearch_Main.Size = new Size(175, 36);
            buttonSearch_Main.TabIndex = 2;
            buttonSearch_Main.Text = "Title Search";
            buttonSearch_Main.TextAlign = ContentAlignment.MiddleRight;
            buttonSearch_Main.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSearch_Main.UseVisualStyleBackColor = true;
            buttonSearch_Main.Click += buttonTitleSearch_Main_Click;
            // 
            // buttonUserDetails_Main
            // 
            buttonUserDetails_Main.Image = (Image)resources.GetObject("buttonUserDetails_Main.Image");
            buttonUserDetails_Main.Location = new Point(12, 71);
            buttonUserDetails_Main.Name = "buttonUserDetails_Main";
            buttonUserDetails_Main.Size = new Size(175, 36);
            buttonUserDetails_Main.TabIndex = 1;
            buttonUserDetails_Main.Text = "User Details";
            buttonUserDetails_Main.TextAlign = ContentAlignment.MiddleRight;
            buttonUserDetails_Main.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonUserDetails_Main.UseVisualStyleBackColor = true;
            buttonUserDetails_Main.Click += buttonUserDetails_Main_Click;
            // 
            // buttonHomepage_Main
            // 
            buttonHomepage_Main.Image = Properties.Resources.IconHomepage;
            buttonHomepage_Main.Location = new Point(12, 29);
            buttonHomepage_Main.Name = "buttonHomepage_Main";
            buttonHomepage_Main.Size = new Size(175, 36);
            buttonHomepage_Main.TabIndex = 0;
            buttonHomepage_Main.Text = "Homepage";
            buttonHomepage_Main.TextAlign = ContentAlignment.MiddleRight;
            buttonHomepage_Main.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHomepage_Main.UseVisualStyleBackColor = true;
            buttonHomepage_Main.Click += buttonHomepage_Main_Click;
            // 
            // tabControlContent_Main
            // 
            tabControlContent_Main.Location = new Point(193, 0);
            tabControlContent_Main.Name = "tabControlContent_Main";
            tabControlContent_Main.SelectedIndex = 0;
            tabControlContent_Main.Size = new Size(854, 629);
            tabControlContent_Main.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 630);
            Controls.Add(tabControlContent_Main);
            Controls.Add(groupBoxMenu_Main);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "[FormMain] Landing Page";
            groupBoxMenu_Main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMenu_Main;
        private Button buttonHomepage_Main;
        private Button buttonSearch_Main;
        private Button buttonUserDetails_Main;
        private TabControl tabControlContent_Main;
        private Button buttonUserLogin_Main;
    }
}