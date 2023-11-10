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
        private void InitializeComponent() {
            labelInputSearch = new Label();
            labelInputYear = new Label();
            labelInputType = new Label();
            textBoxInputSearch = new TextBox();
            textBoxInputYear = new TextBox();
            labelSearchResults = new Label();
            listBoxResponseSearch = new ListBox();
            listBoxFavorites = new ListBox();
            labelFavorites = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitlePoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFavoritePoster).BeginInit();
            SuspendLayout();
            // 
            // labelInputSearch
            // 
            labelInputSearch.AutoSize = true;
            labelInputSearch.Location = new Point(12, 90);
            labelInputSearch.Name = "labelInputSearch";
            labelInputSearch.Size = new Size(60, 21);
            labelInputSearch.TabIndex = 0;
            labelInputSearch.Text = "Search:";
            // 
            // labelInputYear
            // 
            labelInputYear.AutoSize = true;
            labelInputYear.Location = new Point(12, 123);
            labelInputYear.Name = "labelInputYear";
            labelInputYear.Size = new Size(118, 21);
            labelInputYear.TabIndex = 1;
            labelInputYear.Text = "Year of Release:";
            // 
            // labelInputType
            // 
            labelInputType.AutoSize = true;
            labelInputType.Location = new Point(12, 155);
            labelInputType.Name = "labelInputType";
            labelInputType.Size = new Size(45, 21);
            labelInputType.TabIndex = 2;
            labelInputType.Text = "Type:";
            // 
            // textBoxInputSearch
            // 
            textBoxInputSearch.Location = new Point(136, 87);
            textBoxInputSearch.Name = "textBoxInputSearch";
            textBoxInputSearch.Size = new Size(195, 29);
            textBoxInputSearch.TabIndex = 3;
            // 
            // textBoxInputYear
            // 
            textBoxInputYear.Location = new Point(136, 120);
            textBoxInputYear.Name = "textBoxInputYear";
            textBoxInputYear.Size = new Size(195, 29);
            textBoxInputYear.TabIndex = 4;
            // 
            // labelSearchResults
            // 
            labelSearchResults.AutoSize = true;
            labelSearchResults.Location = new Point(12, 214);
            labelSearchResults.Name = "labelSearchResults";
            labelSearchResults.Size = new Size(111, 21);
            labelSearchResults.TabIndex = 6;
            labelSearchResults.Text = "Search Results";
            // 
            // listBoxResponseSearch
            // 
            listBoxResponseSearch.FormattingEnabled = true;
            listBoxResponseSearch.ItemHeight = 21;
            listBoxResponseSearch.Location = new Point(12, 238);
            listBoxResponseSearch.Name = "listBoxResponseSearch";
            listBoxResponseSearch.Size = new Size(319, 172);
            listBoxResponseSearch.TabIndex = 7;
            listBoxResponseSearch.SelectedIndexChanged += listBoxResponseSearch_SelectedIndexChanged;
            // 
            // listBoxFavorites
            // 
            listBoxFavorites.FormattingEnabled = true;
            listBoxFavorites.ItemHeight = 21;
            listBoxFavorites.Location = new Point(12, 455);
            listBoxFavorites.Name = "listBoxFavorites";
            listBoxFavorites.Size = new Size(319, 172);
            listBoxFavorites.TabIndex = 8;
            listBoxFavorites.SelectedIndexChanged += listBoxFavorites_SelectedIndexChanged;
            // 
            // labelFavorites
            // 
            labelFavorites.AutoSize = true;
            labelFavorites.Location = new Point(12, 431);
            labelFavorites.Name = "labelFavorites";
            labelFavorites.Size = new Size(111, 21);
            labelFavorites.TabIndex = 9;
            labelFavorites.Text = "Search Results";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Green;
            buttonSearch.Location = new Point(337, 150);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(119, 38);
            buttonSearch.TabIndex = 10;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonAddFavorites
            // 
            buttonAddFavorites.BackColor = Color.Olive;
            buttonAddFavorites.Location = new Point(337, 313);
            buttonAddFavorites.Name = "buttonAddFavorites";
            buttonAddFavorites.Size = new Size(119, 51);
            buttonAddFavorites.TabIndex = 11;
            buttonAddFavorites.Text = "Add Favorites";
            buttonAddFavorites.UseVisualStyleBackColor = false;
            buttonAddFavorites.Click += buttonAddFavorites_Click;
            // 
            // textBoxTitleDetails
            // 
            textBoxTitleDetails.Location = new Point(462, 238);
            textBoxTitleDetails.Multiline = true;
            textBoxTitleDetails.Name = "textBoxTitleDetails";
            textBoxTitleDetails.Size = new Size(319, 172);
            textBoxTitleDetails.TabIndex = 12;
            // 
            // textBoxFavoriteDetails
            // 
            textBoxFavoriteDetails.Location = new Point(462, 455);
            textBoxFavoriteDetails.Multiline = true;
            textBoxFavoriteDetails.Name = "textBoxFavoriteDetails";
            textBoxFavoriteDetails.Size = new Size(319, 172);
            textBoxFavoriteDetails.TabIndex = 13;
            // 
            // labelTitleDetails
            // 
            labelTitleDetails.AutoSize = true;
            labelTitleDetails.Location = new Point(462, 214);
            labelTitleDetails.Name = "labelTitleDetails";
            labelTitleDetails.Size = new Size(90, 21);
            labelTitleDetails.TabIndex = 14;
            labelTitleDetails.Text = "Title Details";
            // 
            // labelFavoriteDetails
            // 
            labelFavoriteDetails.AutoSize = true;
            labelFavoriteDetails.Location = new Point(462, 431);
            labelFavoriteDetails.Name = "labelFavoriteDetails";
            labelFavoriteDetails.Size = new Size(116, 21);
            labelFavoriteDetails.TabIndex = 15;
            labelFavoriteDetails.Text = "Favorite Details";
            // 
            // labelTitlePoster
            // 
            labelTitlePoster.AutoSize = true;
            labelTitlePoster.Location = new Point(801, 214);
            labelTitlePoster.Name = "labelTitlePoster";
            labelTitlePoster.Size = new Size(86, 21);
            labelTitlePoster.TabIndex = 16;
            labelTitlePoster.Text = "Title Poster";
            // 
            // labelFavoritePoster
            // 
            labelFavoritePoster.AutoSize = true;
            labelFavoritePoster.Location = new Point(801, 431);
            labelFavoritePoster.Name = "labelFavoritePoster";
            labelFavoritePoster.Size = new Size(112, 21);
            labelFavoritePoster.TabIndex = 17;
            labelFavoritePoster.Text = "Favorite Poster";
            // 
            // pictureBoxTitlePoster
            // 
            pictureBoxTitlePoster.BackColor = Color.Transparent;
            pictureBoxTitlePoster.Location = new Point(801, 238);
            pictureBoxTitlePoster.Name = "pictureBoxTitlePoster";
            pictureBoxTitlePoster.Size = new Size(144, 172);
            pictureBoxTitlePoster.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTitlePoster.TabIndex = 18;
            pictureBoxTitlePoster.TabStop = false;
            // 
            // pictureBoxFavoritePoster
            // 
            pictureBoxFavoritePoster.BackColor = Color.Transparent;
            pictureBoxFavoritePoster.Location = new Point(801, 455);
            pictureBoxFavoritePoster.Name = "pictureBoxFavoritePoster";
            pictureBoxFavoritePoster.Size = new Size(144, 172);
            pictureBoxFavoritePoster.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFavoritePoster.TabIndex = 19;
            pictureBoxFavoritePoster.TabStop = false;
            // 
            // comboBoxInputType
            // 
            comboBoxInputType.FormattingEnabled = true;
            comboBoxInputType.Items.AddRange(new object[] { "movie", "series", "episode" });
            comboBoxInputType.Location = new Point(136, 155);
            comboBoxInputType.Name = "comboBoxInputType";
            comboBoxInputType.Size = new Size(195, 29);
            comboBoxInputType.TabIndex = 20;
            // 
            // labelHeader_TitleSearch
            // 
            labelHeader_TitleSearch.AutoSize = true;
            labelHeader_TitleSearch.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader_TitleSearch.Location = new Point(12, 9);
            labelHeader_TitleSearch.Name = "labelHeader_TitleSearch";
            labelHeader_TitleSearch.Size = new Size(167, 37);
            labelHeader_TitleSearch.TabIndex = 21;
            labelHeader_TitleSearch.Text = "Title Search";
            // 
            // FormTitleSearch
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1029, 630);
            Controls.Add(labelHeader_TitleSearch);
            Controls.Add(comboBoxInputType);
            Controls.Add(pictureBoxFavoritePoster);
            Controls.Add(pictureBoxTitlePoster);
            Controls.Add(labelFavoritePoster);
            Controls.Add(labelTitlePoster);
            Controls.Add(labelFavoriteDetails);
            Controls.Add(labelTitleDetails);
            Controls.Add(textBoxFavoriteDetails);
            Controls.Add(textBoxTitleDetails);
            Controls.Add(buttonAddFavorites);
            Controls.Add(buttonSearch);
            Controls.Add(labelFavorites);
            Controls.Add(listBoxFavorites);
            Controls.Add(listBoxResponseSearch);
            Controls.Add(labelSearchResults);
            Controls.Add(textBoxInputYear);
            Controls.Add(textBoxInputSearch);
            Controls.Add(labelInputType);
            Controls.Add(labelInputYear);
            Controls.Add(labelInputSearch);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormTitleSearch";
            Text = "[FormTitleSearch]";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitlePoster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFavoritePoster).EndInit();
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
        private Label labelFavorites;
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
    }
}