namespace MovieDatabase {
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
            this.panelContent_Homepage = new System.Windows.Forms.Panel();
            this.buttonTestApi = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonHomepage = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent_Homepage
            // 
            this.panelContent_Homepage.Location = new System.Drawing.Point(184, 0);
            this.panelContent_Homepage.Name = "panelContent_Homepage";
            this.panelContent_Homepage.Size = new System.Drawing.Size(1018, 692);
            this.panelContent_Homepage.TabIndex = 1;
            // 
            // buttonTestApi
            // 
            this.buttonTestApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTestApi.Image = global::MovieDatabase.Properties.Resources.IconTestApi;
            this.buttonTestApi.Location = new System.Drawing.Point(19, 121);
            this.buttonTestApi.Name = "buttonTestApi";
            this.buttonTestApi.Size = new System.Drawing.Size(140, 41);
            this.buttonTestApi.TabIndex = 5;
            this.buttonTestApi.Text = "Test API";
            this.buttonTestApi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTestApi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTestApi.UseVisualStyleBackColor = true;
            this.buttonTestApi.Click += new System.EventHandler(this.buttonTestAPI_Click);
            // 
            // buttonAccount
            // 
            this.buttonAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccount.Image = global::MovieDatabase.Properties.Resources.IconAccount;
            this.buttonAccount.Location = new System.Drawing.Point(19, 74);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(140, 41);
            this.buttonAccount.TabIndex = 4;
            this.buttonAccount.Text = "Account";
            this.buttonAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAccount.UseVisualStyleBackColor = true;
            // 
            // buttonHomepage
            // 
            this.buttonHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHomepage.Image = global::MovieDatabase.Properties.Resources.IconHomepage;
            this.buttonHomepage.Location = new System.Drawing.Point(19, 27);
            this.buttonHomepage.Name = "buttonHomepage";
            this.buttonHomepage.Size = new System.Drawing.Size(140, 41);
            this.buttonHomepage.TabIndex = 3;
            this.buttonHomepage.Text = "Homepage";
            this.buttonHomepage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHomepage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHomepage.UseVisualStyleBackColor = true;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxMenu.Controls.Add(this.buttonHomepage);
            this.groupBoxMenu.Controls.Add(this.buttonTestApi);
            this.groupBoxMenu.Controls.Add(this.buttonAccount);
            this.groupBoxMenu.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(188, 692);
            this.groupBoxMenu.TabIndex = 6;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // FormHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.panelContent_Homepage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormHomepage";
            this.Text = "[FormHomepage] Landing Page";
            this.groupBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContent_Homepage;
        private System.Windows.Forms.Button buttonTestApi;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonHomepage;
        private System.Windows.Forms.GroupBox groupBoxMenu;
    }
}

