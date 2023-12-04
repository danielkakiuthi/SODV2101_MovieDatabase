namespace MovieDatabase {
    partial class FormTitleSearch {
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
        private void InitializeComponent()
        {
            labelInputSearch = new Label();
            labelInputYear = new Label();
            labelInputType = new Label();
            textBoxInputSearch = new TextBox();
            textBoxInputYear = new TextBox();
            labelSearchResults = new Label();
            listBoxResponseSearch = new ListBox();
            listBoxFavorites = new ListBox();
            buttonSearch = new Button();
            buttonAddFavorites = new Button();
            textBoxTitleDetails = new TextBox();
            textBoxFavoriteDetails = new TextBox();
            labelTitleDetails = new Label();
            labelFavoriteDetails = new Label();
            labelTitlePoster = new Label();
            labelFavoritePoster = new Label();
            pictureBoxTitlePoster = new PictureBox();
            pictureBoxFavoritePoster = new PictureBox();
            comboBoxInputType = new ComboBox();
            labelHeader_TitleSearch = new Label();
            gp_SearchFavorites = new GroupBox();
            groupBox1 = new GroupBox();
            buttonDelFavorites = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitlePoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFavoritePoster).BeginInit();
            gp_SearchFavorites.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelInputSearch
            // 
            labelInputSearch.AutoSize = true;
            labelInputSearch.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelInputSearch.ForeColor = Color.White;
            labelInputSearch.Location = new Point(12, 56);
            labelInputSearch.Name = "labelInputSearch";
            labelInputSearch.Size = new Size(66, 23);
            labelInputSearch.TabIndex = 0;
            labelInputSearch.Text = "Search:";
            // 
            // labelInputYear
            // 
            labelInputYear.AutoSize = true;
            labelInputYear.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelInputYear.ForeColor = Color.White;
            labelInputYear.Location = new Point(12, 90);
            labelInputYear.Name = "labelInputYear";
            labelInputYear.Size = new Size(131, 23);
            labelInputYear.TabIndex = 1;
            labelInputYear.Text = "Year of Release:";
            // 
            // labelInputType
            // 
            labelInputType.AutoSize = true;
            labelInputType.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelInputType.ForeColor = Color.White;
            labelInputType.Location = new Point(12, 121);
            labelInputType.Name = "labelInputType";
            labelInputType.Size = new Size(52, 23);
            labelInputType.TabIndex = 2;
            labelInputType.Text = "Type:";
            // 
            // textBoxInputSearch
            // 
            textBoxInputSearch.Location = new Point(141, 53);
            textBoxInputSearch.Name = "textBoxInputSearch";
            textBoxInputSearch.Size = new Size(195, 29);
            textBoxInputSearch.TabIndex = 3;
            // 
            // textBoxInputYear
            // 
            textBoxInputYear.Location = new Point(141, 87);
            textBoxInputYear.Name = "textBoxInputYear";
            textBoxInputYear.Size = new Size(195, 29);
            textBoxInputYear.TabIndex = 4;
            // 
            // labelSearchResults
            // 
            labelSearchResults.AutoSize = true;
            labelSearchResults.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSearchResults.ForeColor = Color.White;
            labelSearchResults.Location = new Point(0, 3);
            labelSearchResults.Name = "labelSearchResults";
            labelSearchResults.Size = new Size(119, 23);
            labelSearchResults.TabIndex = 6;
            labelSearchResults.Text = "Search Results";
            // 
            // listBoxResponseSearch
            // 
            listBoxResponseSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxResponseSearch.FormattingEnabled = true;
            listBoxResponseSearch.ItemHeight = 25;
            listBoxResponseSearch.Location = new Point(12, 238);
            listBoxResponseSearch.Name = "listBoxResponseSearch";
            listBoxResponseSearch.Size = new Size(319, 279);
            listBoxResponseSearch.TabIndex = 7;
            listBoxResponseSearch.SelectedIndexChanged += listBoxResponseSearch_SelectedIndexChanged;
            // 
            // listBoxFavorites
            // 
            listBoxFavorites.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxFavorites.FormattingEnabled = true;
            listBoxFavorites.ItemHeight = 25;
            listBoxFavorites.Location = new Point(868, 238);
            listBoxFavorites.Name = "listBoxFavorites";
            listBoxFavorites.Size = new Size(319, 279);
            listBoxFavorites.TabIndex = 8;
            listBoxFavorites.SelectedIndexChanged += listBoxFavorites_SelectedIndexChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Green;
            buttonSearch.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(10, 156);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(326, 38);
            buttonSearch.TabIndex = 10;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonAddFavorites
            // 
            buttonAddFavorites.BackColor = Color.Olive;
            buttonAddFavorites.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddFavorites.ForeColor = Color.White;
            buttonAddFavorites.Location = new Point(8, 329);
            buttonAddFavorites.Name = "buttonAddFavorites";
            buttonAddFavorites.Size = new Size(181, 38);
            buttonAddFavorites.TabIndex = 11;
            buttonAddFavorites.Text = "Add to Favorites";
            buttonAddFavorites.UseVisualStyleBackColor = false;
            buttonAddFavorites.Click += buttonAddFavorites_Click;
            // 
            // textBoxTitleDetails
            // 
            textBoxTitleDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitleDetails.Location = new Point(12, 598);
            textBoxTitleDetails.Multiline = true;
            textBoxTitleDetails.Name = "textBoxTitleDetails";
            textBoxTitleDetails.Size = new Size(319, 379);
            textBoxTitleDetails.TabIndex = 12;
            // 
            // textBoxFavoriteDetails
            // 
            textBoxFavoriteDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFavoriteDetails.Location = new Point(868, 598);
            textBoxFavoriteDetails.Multiline = true;
            textBoxFavoriteDetails.Name = "textBoxFavoriteDetails";
            textBoxFavoriteDetails.Size = new Size(319, 379);
            textBoxFavoriteDetails.TabIndex = 13;
            // 
            // labelTitleDetails
            // 
            labelTitleDetails.AutoSize = true;
            labelTitleDetails.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitleDetails.ForeColor = Color.White;
            labelTitleDetails.Location = new Point(12, 571);
            labelTitleDetails.Name = "labelTitleDetails";
            labelTitleDetails.Size = new Size(118, 26);
            labelTitleDetails.TabIndex = 14;
            labelTitleDetails.Text = "Title Details";
            // 
            // labelFavoriteDetails
            // 
            labelFavoriteDetails.AutoSize = true;
            labelFavoriteDetails.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelFavoriteDetails.ForeColor = Color.White;
            labelFavoriteDetails.Location = new Point(868, 570);
            labelFavoriteDetails.Name = "labelFavoriteDetails";
            labelFavoriteDetails.Size = new Size(150, 26);
            labelFavoriteDetails.TabIndex = 15;
            labelFavoriteDetails.Text = "Favorite Details";
            // 
            // labelTitlePoster
            // 
            labelTitlePoster.AutoSize = true;
            labelTitlePoster.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitlePoster.ForeColor = Color.White;
            labelTitlePoster.Location = new Point(361, 20);
            labelTitlePoster.Name = "labelTitlePoster";
            labelTitlePoster.Size = new Size(97, 23);
            labelTitlePoster.TabIndex = 16;
            labelTitlePoster.Text = "Title Poster";
            // 
            // labelFavoritePoster
            // 
            labelFavoritePoster.AutoSize = true;
            labelFavoritePoster.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelFavoritePoster.ForeColor = Color.White;
            labelFavoritePoster.Location = new Point(411, 21);
            labelFavoritePoster.Name = "labelFavoritePoster";
            labelFavoritePoster.Size = new Size(68, 26);
            labelFavoritePoster.TabIndex = 17;
            labelFavoritePoster.Text = "Poster";
            // 
            // pictureBoxTitlePoster
            // 
            pictureBoxTitlePoster.BackColor = Color.Transparent;
            pictureBoxTitlePoster.Location = new Point(363, 238);
            pictureBoxTitlePoster.Name = "pictureBoxTitlePoster";
            pictureBoxTitlePoster.Size = new Size(427, 739);
            pictureBoxTitlePoster.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTitlePoster.TabIndex = 18;
            pictureBoxTitlePoster.TabStop = false;
            // 
            // pictureBoxFavoritePoster
            // 
            pictureBoxFavoritePoster.BackColor = Color.Transparent;
            pictureBoxFavoritePoster.Location = new Point(1239, 238);
            pictureBoxFavoritePoster.Name = "pictureBoxFavoritePoster";
            pictureBoxFavoritePoster.Size = new Size(427, 739);
            pictureBoxFavoritePoster.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFavoritePoster.TabIndex = 19;
            pictureBoxFavoritePoster.TabStop = false;
            // 
            // comboBoxInputType
            // 
            comboBoxInputType.FormattingEnabled = true;
            comboBoxInputType.Items.AddRange(new object[] { "movie", "series", "episode" });
            comboBoxInputType.Location = new Point(141, 121);
            comboBoxInputType.Name = "comboBoxInputType";
            comboBoxInputType.Size = new Size(195, 29);
            comboBoxInputType.TabIndex = 20;
            comboBoxInputType.SelectedIndexChanged += comboBoxInputType_SelectedIndexChanged;
            // 
            // labelHeader_TitleSearch
            // 
            labelHeader_TitleSearch.AutoSize = true;
            labelHeader_TitleSearch.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader_TitleSearch.ForeColor = Color.White;
            labelHeader_TitleSearch.Location = new Point(12, 9);
            labelHeader_TitleSearch.Name = "labelHeader_TitleSearch";
            labelHeader_TitleSearch.Size = new Size(161, 35);
            labelHeader_TitleSearch.TabIndex = 21;
            labelHeader_TitleSearch.Text = "Title Search";
            // 
            // gp_SearchFavorites
            // 
            gp_SearchFavorites.Controls.Add(buttonDelFavorites);
            gp_SearchFavorites.Controls.Add(labelFavoritePoster);
            gp_SearchFavorites.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            gp_SearchFavorites.ForeColor = Color.White;
            gp_SearchFavorites.Location = new Point(840, 193);
            gp_SearchFavorites.Name = "gp_SearchFavorites";
            gp_SearchFavorites.Size = new Size(844, 792);
            gp_SearchFavorites.TabIndex = 22;
            gp_SearchFavorites.TabStop = false;
            gp_SearchFavorites.Text = "Favorites";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelSearchResults);
            groupBox1.Controls.Add(labelTitlePoster);
            groupBox1.Controls.Add(buttonAddFavorites);
            groupBox1.Location = new Point(4, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(802, 791);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // buttonDelFavorites
            // 
            buttonDelFavorites.BackColor = Color.Olive;
            buttonDelFavorites.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelFavorites.ForeColor = Color.White;
            buttonDelFavorites.Location = new Point(28, 330);
            buttonDelFavorites.Name = "buttonDelFavorites";
            buttonDelFavorites.Size = new Size(181, 38);
            buttonDelFavorites.TabIndex = 24;
            buttonDelFavorites.Text = "Delete from Favorites";
            buttonDelFavorites.UseVisualStyleBackColor = false;
            buttonDelFavorites.Click += buttonDelFavorites_Click;
            // 
            // FormTitleSearch
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1700, 989);
            Controls.Add(labelHeader_TitleSearch);
            Controls.Add(comboBoxInputType);
            Controls.Add(pictureBoxFavoritePoster);
            Controls.Add(pictureBoxTitlePoster);
            Controls.Add(labelFavoriteDetails);
            Controls.Add(labelTitleDetails);
            Controls.Add(textBoxFavoriteDetails);
            Controls.Add(textBoxTitleDetails);
            Controls.Add(buttonSearch);
            Controls.Add(listBoxFavorites);
            Controls.Add(listBoxResponseSearch);
            Controls.Add(textBoxInputYear);
            Controls.Add(textBoxInputSearch);
            Controls.Add(labelInputType);
            Controls.Add(labelInputYear);
            Controls.Add(labelInputSearch);
            Controls.Add(gp_SearchFavorites);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormTitleSearch";
            Text = "[FormTitleSearch]";
            Load += FormTitleSearch_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitlePoster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFavoritePoster).EndInit();
            gp_SearchFavorites.ResumeLayout(false);
            gp_SearchFavorites.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInputSearch;
        private Label labelInputYear;
        private Label labelInputType;
        private TextBox textBoxInputSearch;
        private TextBox textBoxInputYear;
        private Label labelSearchResults;
        private ListBox listBoxResponseSearch;
        private ListBox listBoxFavorites;
        private Button buttonSearch;
        private Button buttonAddFavorites;
        private TextBox textBoxTitleDetails;
        private TextBox textBoxFavoriteDetails;
        private Label labelTitleDetails;
        private Label labelFavoriteDetails;
        private Label labelTitlePoster;
        private Label labelFavoritePoster;
        private PictureBox pictureBoxTitlePoster;
        private PictureBox pictureBoxFavoritePoster;
        private ComboBox comboBoxInputType;
        private Label labelHeader_TitleSearch;
        private GroupBox gp_SearchFavorites;
        private GroupBox groupBox1;
        private Button buttonDelFavorites;
    }
}