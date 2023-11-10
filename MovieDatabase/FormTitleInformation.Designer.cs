namespace MovieDatabase {
    partial class FormTitleInformation {
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
            this.textBoxInputSearch = new System.Windows.Forms.TextBox();
            this.labelInputSearch = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelInputYear = new System.Windows.Forms.Label();
            this.textBoxInputYear = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxInputType = new System.Windows.Forms.ComboBox();
            this.listBoxResponseSearch = new System.Windows.Forms.ListBox();
            this.labelSearchResults = new System.Windows.Forms.Label();
            this.listBoxFavorites = new System.Windows.Forms.ListBox();
            this.labelFavorites = new System.Windows.Forms.Label();
            this.labelTitleDetails = new System.Windows.Forms.Label();
            this.labelFavoriteDetails = new System.Windows.Forms.Label();
            this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
            this.labelPoster = new System.Windows.Forms.Label();
            this.buttonAddFavorites = new System.Windows.Forms.Button();
            this.textBoxTitleDetails = new System.Windows.Forms.TextBox();
            this.textBoxFavoriteDetails = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInputSearch
            // 
            this.textBoxInputSearch.Location = new System.Drawing.Point(146, 3);
            this.textBoxInputSearch.Name = "textBoxInputSearch";
            this.textBoxInputSearch.Size = new System.Drawing.Size(229, 26);
            this.textBoxInputSearch.TabIndex = 1;
            // 
            // labelInputSearch
            // 
            this.labelInputSearch.AutoSize = true;
            this.labelInputSearch.Location = new System.Drawing.Point(12, 9);
            this.labelInputSearch.Name = "labelInputSearch";
            this.labelInputSearch.Size = new System.Drawing.Size(64, 20);
            this.labelInputSearch.TabIndex = 4;
            this.labelInputSearch.Text = "Search:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Green;
            this.buttonSearch.Location = new System.Drawing.Point(381, 54);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(124, 43);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelInputYear
            // 
            this.labelInputYear.AutoSize = true;
            this.labelInputYear.Location = new System.Drawing.Point(12, 40);
            this.labelInputYear.Name = "labelInputYear";
            this.labelInputYear.Size = new System.Drawing.Size(128, 20);
            this.labelInputYear.TabIndex = 7;
            this.labelInputYear.Text = "Year of Release:";
            // 
            // textBoxInputYear
            // 
            this.textBoxInputYear.Location = new System.Drawing.Point(146, 37);
            this.textBoxInputYear.Name = "textBoxInputYear";
            this.textBoxInputYear.Size = new System.Drawing.Size(229, 26);
            this.textBoxInputYear.TabIndex = 2;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 77);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(47, 20);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Type:";
            // 
            // comboBoxInputType
            // 
            this.comboBoxInputType.FormattingEnabled = true;
            this.comboBoxInputType.Items.AddRange(new object[] {
            "movie",
            "series",
            "episode"});
            this.comboBoxInputType.Location = new System.Drawing.Point(146, 69);
            this.comboBoxInputType.Name = "comboBoxInputType";
            this.comboBoxInputType.Size = new System.Drawing.Size(229, 28);
            this.comboBoxInputType.TabIndex = 3;
            // 
            // listBoxResponseSearch
            // 
            this.listBoxResponseSearch.FormattingEnabled = true;
            this.listBoxResponseSearch.ItemHeight = 20;
            this.listBoxResponseSearch.Location = new System.Drawing.Point(16, 149);
            this.listBoxResponseSearch.Name = "listBoxResponseSearch";
            this.listBoxResponseSearch.Size = new System.Drawing.Size(359, 224);
            this.listBoxResponseSearch.TabIndex = 5;
            this.listBoxResponseSearch.SelectedIndexChanged += new System.EventHandler(this.listBoxResponseSearch_SelectedIndexChanged);
            // 
            // labelSearchResults
            // 
            this.labelSearchResults.AutoSize = true;
            this.labelSearchResults.Location = new System.Drawing.Point(12, 126);
            this.labelSearchResults.Name = "labelSearchResults";
            this.labelSearchResults.Size = new System.Drawing.Size(118, 20);
            this.labelSearchResults.TabIndex = 9;
            this.labelSearchResults.Text = "Search Results";
            // 
            // listBoxFavorites
            // 
            this.listBoxFavorites.FormattingEnabled = true;
            this.listBoxFavorites.ItemHeight = 20;
            this.listBoxFavorites.Location = new System.Drawing.Point(16, 467);
            this.listBoxFavorites.Name = "listBoxFavorites";
            this.listBoxFavorites.Size = new System.Drawing.Size(359, 224);
            this.listBoxFavorites.TabIndex = 10;
            this.listBoxFavorites.SelectedIndexChanged += new System.EventHandler(this.listBoxFavorites_SelectedIndexChanged);
            // 
            // labelFavorites
            // 
            this.labelFavorites.AutoSize = true;
            this.labelFavorites.Location = new System.Drawing.Point(12, 444);
            this.labelFavorites.Name = "labelFavorites";
            this.labelFavorites.Size = new System.Drawing.Size(74, 20);
            this.labelFavorites.TabIndex = 11;
            this.labelFavorites.Text = "Favorites";
            // 
            // labelTitleDetails
            // 
            this.labelTitleDetails.AutoSize = true;
            this.labelTitleDetails.Location = new System.Drawing.Point(478, 126);
            this.labelTitleDetails.Name = "labelTitleDetails";
            this.labelTitleDetails.Size = new System.Drawing.Size(91, 20);
            this.labelTitleDetails.TabIndex = 13;
            this.labelTitleDetails.Text = "Title Details";
            // 
            // labelFavoriteDetails
            // 
            this.labelFavoriteDetails.AutoSize = true;
            this.labelFavoriteDetails.Location = new System.Drawing.Point(478, 444);
            this.labelFavoriteDetails.Name = "labelFavoriteDetails";
            this.labelFavoriteDetails.Size = new System.Drawing.Size(119, 20);
            this.labelFavoriteDetails.TabIndex = 15;
            this.labelFavoriteDetails.Text = "Favorite Details";
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.Location = new System.Drawing.Point(910, 100);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(241, 339);
            this.pictureBoxPoster.TabIndex = 16;
            this.pictureBoxPoster.TabStop = false;
            // 
            // labelPoster
            // 
            this.labelPoster.AutoSize = true;
            this.labelPoster.Location = new System.Drawing.Point(906, 72);
            this.labelPoster.Name = "labelPoster";
            this.labelPoster.Size = new System.Drawing.Size(55, 20);
            this.labelPoster.TabIndex = 17;
            this.labelPoster.Text = "Poster";
            // 
            // buttonAddFavorites
            // 
            this.buttonAddFavorites.Location = new System.Drawing.Point(381, 267);
            this.buttonAddFavorites.Name = "buttonAddFavorites";
            this.buttonAddFavorites.Size = new System.Drawing.Size(96, 52);
            this.buttonAddFavorites.TabIndex = 18;
            this.buttonAddFavorites.Text = "Add Favorites";
            this.buttonAddFavorites.UseVisualStyleBackColor = true;
            this.buttonAddFavorites.Click += new System.EventHandler(this.buttonAddFavorites_Click);
            // 
            // textBoxTitleDetails
            // 
            this.textBoxTitleDetails.Location = new System.Drawing.Point(482, 148);
            this.textBoxTitleDetails.Multiline = true;
            this.textBoxTitleDetails.Name = "textBoxTitleDetails";
            this.textBoxTitleDetails.Size = new System.Drawing.Size(359, 225);
            this.textBoxTitleDetails.TabIndex = 19;
            // 
            // textBoxFavoriteDetails
            // 
            this.textBoxFavoriteDetails.Location = new System.Drawing.Point(482, 467);
            this.textBoxFavoriteDetails.Multiline = true;
            this.textBoxFavoriteDetails.Name = "textBoxFavoriteDetails";
            this.textBoxFavoriteDetails.Size = new System.Drawing.Size(359, 225);
            this.textBoxFavoriteDetails.TabIndex = 20;
            // 
            // FormTitleInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.textBoxFavoriteDetails);
            this.Controls.Add(this.textBoxTitleDetails);
            this.Controls.Add(this.buttonAddFavorites);
            this.Controls.Add(this.labelPoster);
            this.Controls.Add(this.pictureBoxPoster);
            this.Controls.Add(this.labelFavoriteDetails);
            this.Controls.Add(this.labelTitleDetails);
            this.Controls.Add(this.labelFavorites);
            this.Controls.Add(this.listBoxFavorites);
            this.Controls.Add(this.labelSearchResults);
            this.Controls.Add(this.listBoxResponseSearch);
            this.Controls.Add(this.comboBoxInputType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelInputYear);
            this.Controls.Add(this.textBoxInputYear);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelInputSearch);
            this.Controls.Add(this.textBoxInputSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTitleInformation";
            this.Text = "[FormTitleInformation] Display Title Information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInputSearch;
        private System.Windows.Forms.Label labelInputSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelInputYear;
        private System.Windows.Forms.TextBox textBoxInputYear;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxInputType;
        private System.Windows.Forms.ListBox listBoxResponseSearch;
        private System.Windows.Forms.Label labelSearchResults;
        private System.Windows.Forms.ListBox listBoxFavorites;
        private System.Windows.Forms.Label labelFavorites;
        private System.Windows.Forms.Label labelTitleDetails;
        private System.Windows.Forms.Label labelFavoriteDetails;
        private System.Windows.Forms.PictureBox pictureBoxPoster;
        private System.Windows.Forms.Label labelPoster;
        private System.Windows.Forms.Button buttonAddFavorites;
        private System.Windows.Forms.TextBox textBoxTitleDetails;
        private System.Windows.Forms.TextBox textBoxFavoriteDetails;
    }
}