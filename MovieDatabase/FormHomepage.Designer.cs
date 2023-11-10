namespace MovieDatabase {
    partial class FormHomepage {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomepage));
            groupBoxMenu = new GroupBox();
            buttonSearch_Menu = new Button();
            buttonAccount_Menu = new Button();
            buttonHomepage_Menu = new Button();
            panelContent_Homepage = new Panel();
            groupBoxMenu.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMenu
            // 
            groupBoxMenu.BackColor = SystemColors.ControlDarkDark;
            groupBoxMenu.Controls.Add(buttonSearch_Menu);
            groupBoxMenu.Controls.Add(buttonAccount_Menu);
            groupBoxMenu.Controls.Add(buttonHomepage_Menu);
            groupBoxMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxMenu.Location = new Point(0, 0);
            groupBoxMenu.Margin = new Padding(4);
            groupBoxMenu.Name = "groupBoxMenu";
            groupBoxMenu.Padding = new Padding(4);
            groupBoxMenu.Size = new Size(194, 629);
            groupBoxMenu.TabIndex = 0;
            groupBoxMenu.TabStop = false;
            groupBoxMenu.Text = "Menu";
            // 
            // buttonSearch_Menu
            // 
            buttonSearch_Menu.Image = (Image)resources.GetObject("buttonSearch_Menu.Image");
            buttonSearch_Menu.Location = new Point(12, 113);
            buttonSearch_Menu.Name = "buttonSearch_Menu";
            buttonSearch_Menu.Size = new Size(175, 36);
            buttonSearch_Menu.TabIndex = 2;
            buttonSearch_Menu.Text = "Search";
            buttonSearch_Menu.TextAlign = ContentAlignment.MiddleRight;
            buttonSearch_Menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSearch_Menu.UseVisualStyleBackColor = true;
            buttonSearch_Menu.Click += buttonSearch_Menu_Click;
            // 
            // buttonAccount_Menu
            // 
            buttonAccount_Menu.Image = (Image)resources.GetObject("buttonAccount_Menu.Image");
            buttonAccount_Menu.Location = new Point(12, 71);
            buttonAccount_Menu.Name = "buttonAccount_Menu";
            buttonAccount_Menu.Size = new Size(175, 36);
            buttonAccount_Menu.TabIndex = 1;
            buttonAccount_Menu.Text = "Account";
            buttonAccount_Menu.TextAlign = ContentAlignment.MiddleRight;
            buttonAccount_Menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAccount_Menu.UseVisualStyleBackColor = true;
            // 
            // buttonHomepage_Menu
            // 
            buttonHomepage_Menu.Image = Properties.Resources.IconHomepage;
            buttonHomepage_Menu.Location = new Point(12, 29);
            buttonHomepage_Menu.Name = "buttonHomepage_Menu";
            buttonHomepage_Menu.Size = new Size(175, 36);
            buttonHomepage_Menu.TabIndex = 0;
            buttonHomepage_Menu.Text = "Homepage";
            buttonHomepage_Menu.TextAlign = ContentAlignment.MiddleRight;
            buttonHomepage_Menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHomepage_Menu.UseVisualStyleBackColor = true;
            // 
            // panelContent_Homepage
            // 
            panelContent_Homepage.BackColor = Color.Silver;
            panelContent_Homepage.Location = new Point(201, 0);
            panelContent_Homepage.Name = "panelContent_Homepage";
            panelContent_Homepage.Size = new Size(842, 629);
            panelContent_Homepage.TabIndex = 1;
            // 
            // FormHomepage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 630);
            Controls.Add(panelContent_Homepage);
            Controls.Add(groupBoxMenu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormHomepage";
            Text = "[FormHomepage] Landing Page";
            groupBoxMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMenu;
        private Panel panelContent_Homepage;
        private Button buttonHomepage_Menu;
        private Button buttonSearch_Menu;
        private Button buttonAccount_Menu;
    }
}