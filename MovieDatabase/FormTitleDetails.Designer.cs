namespace MovieDatabase {
    partial class FormTitleDetails {
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
            labelHeader_TitleDetails = new Label();
            pictureBoxFavoritePoster = new PictureBox();
            labelFavoriteDetails = new Label();
            textBoxFavoriteDetails = new TextBox();
            labelFavorites = new Label();
            listBoxFavorites = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFavoritePoster).BeginInit();
            SuspendLayout();
            // 
            // labelHeader_TitleDetails
            // 
            labelHeader_TitleDetails.AutoSize = true;
            labelHeader_TitleDetails.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader_TitleDetails.Location = new Point(12, 9);
            labelHeader_TitleDetails.Name = "labelHeader_TitleDetails";
            labelHeader_TitleDetails.Size = new Size(171, 37);
            labelHeader_TitleDetails.TabIndex = 22;
            labelHeader_TitleDetails.Text = "Title Details";
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
            // FormTitleDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(pictureBoxFavoritePoster);
            Controls.Add(labelFavoriteDetails);
            Controls.Add(textBoxFavoriteDetails);
            Controls.Add(labelFavorites);
            Controls.Add(listBoxFavorites);
            Controls.Add(labelHeader_TitleDetails);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormTitleDetails";
            Text = "[FormTitleDetails]";
            Load += FormTitleDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFavoritePoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader_TitleDetails;
        private PictureBox pictureBoxFavoritePoster;
        private Label labelFavoriteDetails;
        private TextBox textBoxFavoriteDetails;
        private Label labelFavorites;
        private ListBox listBoxFavorites;
    }
}