namespace MovieDatabase {
    partial class FormFavorites {
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
            labelHeader_Favorites = new Label();
            pictureBoxFavoritePoster = new PictureBox();
            labelFavoriteDetails = new Label();
            textBoxFavoriteDetails = new TextBox();
            labelFavorites = new Label();
            listBoxFavorites = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFavoritePoster).BeginInit();
            SuspendLayout();
            // 
            // labelHeader_Favorites
            // 
            labelHeader_Favorites.AutoSize = true;
            labelHeader_Favorites.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader_Favorites.ForeColor = Color.White;
            labelHeader_Favorites.Location = new Point(12, 9);
            labelHeader_Favorites.Name = "labelHeader_Favorites";
            labelHeader_Favorites.Size = new Size(134, 37);
            labelHeader_Favorites.TabIndex = 22;
            labelHeader_Favorites.Text = "Favorites";
            // 
            // pictureBoxFavoritePoster
            // 
            pictureBoxFavoritePoster.BackColor = Color.Transparent;
            pictureBoxFavoritePoster.Location = new Point(837, 241);
            pictureBoxFavoritePoster.Name = "pictureBoxFavoritePoster";
            pictureBoxFavoritePoster.Size = new Size(144, 172);
            pictureBoxFavoritePoster.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFavoritePoster.TabIndex = 27;
            pictureBoxFavoritePoster.TabStop = false;
            // 
            // labelFavoriteDetails
            // 
            labelFavoriteDetails.AutoSize = true;
            labelFavoriteDetails.ForeColor = Color.White;
            labelFavoriteDetails.Location = new Point(498, 217);
            labelFavoriteDetails.Name = "labelFavoriteDetails";
            labelFavoriteDetails.Size = new Size(116, 21);
            labelFavoriteDetails.TabIndex = 26;
            labelFavoriteDetails.Text = "Favorite Details";
            // 
            // textBoxFavoriteDetails
            // 
            textBoxFavoriteDetails.Location = new Point(498, 241);
            textBoxFavoriteDetails.Multiline = true;
            textBoxFavoriteDetails.Name = "textBoxFavoriteDetails";
            textBoxFavoriteDetails.Size = new Size(319, 172);
            textBoxFavoriteDetails.TabIndex = 25;
            // 
            // labelFavorites
            // 
            labelFavorites.AutoSize = true;
            labelFavorites.ForeColor = Color.White;
            labelFavorites.Location = new Point(48, 217);
            labelFavorites.Name = "labelFavorites";
            labelFavorites.Size = new Size(111, 21);
            labelFavorites.TabIndex = 24;
            labelFavorites.Text = "Search Results";
            // 
            // listBoxFavorites
            // 
            listBoxFavorites.FormattingEnabled = true;
            listBoxFavorites.ItemHeight = 21;
            listBoxFavorites.Location = new Point(48, 241);
            listBoxFavorites.Name = "listBoxFavorites";
            listBoxFavorites.Size = new Size(319, 172);
            listBoxFavorites.TabIndex = 23;
            // 
            // FormFavorites
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1029, 630);
            Controls.Add(pictureBoxFavoritePoster);
            Controls.Add(labelFavoriteDetails);
            Controls.Add(textBoxFavoriteDetails);
            Controls.Add(labelFavorites);
            Controls.Add(listBoxFavorites);
            Controls.Add(labelHeader_Favorites);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormFavorites";
            Text = "[FormTitleDetails]";
            Load += FormFavorites_Load;
            Paint += FormFavorites_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFavoritePoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader_Favorites;
        private PictureBox pictureBoxFavoritePoster;
        private Label labelFavoriteDetails;
        private TextBox textBoxFavoriteDetails;
        private Label labelFavorites;
        private ListBox listBoxFavorites;
    }
}