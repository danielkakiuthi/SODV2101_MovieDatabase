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
        private void InitializeComponent()
        {
            labelHeader_Favorites = new Label();
            pictureBoxFavoritePoster = new PictureBox();
            listBoxFavorites = new ListBox();
            gp_SearchFavorites = new GroupBox();
            label5 = new Label();
            textBoxPlot = new TextBox();
            labelFavoritePoster = new Label();
            label4 = new Label();
            textBoxDirector = new TextBox();
            textBoxGenre = new TextBox();
            labelTitleDetails = new Label();
            label3 = new Label();
            textBoxRated = new TextBox();
            textBoxRuntime = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxReleased = new TextBox();
            buttonDelFavorites = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFavoritePoster).BeginInit();
            gp_SearchFavorites.SuspendLayout();
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
            pictureBoxFavoritePoster.Location = new Point(680, 124);
            pictureBoxFavoritePoster.Name = "pictureBoxFavoritePoster";
            pictureBoxFavoritePoster.Size = new Size(427, 739);
            pictureBoxFavoritePoster.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFavoritePoster.TabIndex = 26;
            pictureBoxFavoritePoster.TabStop = false;
            // 
            // listBoxFavorites
            // 
            listBoxFavorites.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxFavorites.FormattingEnabled = true;
            listBoxFavorites.ItemHeight = 25;
            listBoxFavorites.Location = new Point(285, 109);
            listBoxFavorites.Name = "listBoxFavorites";
            listBoxFavorites.Size = new Size(365, 754);
            listBoxFavorites.TabIndex = 23;
            listBoxFavorites.SelectedIndexChanged += listBoxFavorites_SelectedIndexChanged;
            // 
            // gp_SearchFavorites
            // 
            gp_SearchFavorites.Controls.Add(label5);
            gp_SearchFavorites.Controls.Add(textBoxPlot);
            gp_SearchFavorites.Controls.Add(labelFavoritePoster);
            gp_SearchFavorites.Controls.Add(label4);
            gp_SearchFavorites.Controls.Add(textBoxDirector);
            gp_SearchFavorites.Controls.Add(textBoxGenre);
            gp_SearchFavorites.Controls.Add(labelTitleDetails);
            gp_SearchFavorites.Controls.Add(label3);
            gp_SearchFavorites.Controls.Add(textBoxRated);
            gp_SearchFavorites.Controls.Add(textBoxRuntime);
            gp_SearchFavorites.Controls.Add(label1);
            gp_SearchFavorites.Controls.Add(label2);
            gp_SearchFavorites.Controls.Add(textBoxReleased);
            gp_SearchFavorites.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            gp_SearchFavorites.ForeColor = Color.White;
            gp_SearchFavorites.Location = new Point(257, 79);
            gp_SearchFavorites.Name = "gp_SearchFavorites";
            gp_SearchFavorites.Size = new Size(1434, 801);
            gp_SearchFavorites.TabIndex = 27;
            gp_SearchFavorites.TabStop = false;
            gp_SearchFavorites.Text = "Favorites";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(881, 375);
            label5.Name = "label5";
            label5.Size = new Size(45, 26);
            label5.TabIndex = 39;
            label5.Text = "Plot";
            // 
            // textBoxPlot
            // 
            textBoxPlot.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPlot.Location = new Point(881, 407);
            textBoxPlot.Multiline = true;
            textBoxPlot.Name = "textBoxPlot";
            textBoxPlot.Size = new Size(521, 377);
            textBoxPlot.TabIndex = 38;
            // 
            // labelFavoritePoster
            // 
            labelFavoritePoster.AutoSize = true;
            labelFavoritePoster.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelFavoritePoster.ForeColor = Color.White;
            labelFavoritePoster.Location = new Point(435, 21);
            labelFavoritePoster.Name = "labelFavoritePoster";
            labelFavoritePoster.Size = new Size(68, 26);
            labelFavoritePoster.TabIndex = 17;
            labelFavoritePoster.Text = "Poster";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(881, 305);
            label4.Name = "label4";
            label4.Size = new Size(64, 26);
            label4.TabIndex = 37;
            label4.Text = "Genre";
            // 
            // textBoxDirector
            // 
            textBoxDirector.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDirector.Location = new Point(881, 55);
            textBoxDirector.Name = "textBoxDirector";
            textBoxDirector.Size = new Size(521, 33);
            textBoxDirector.TabIndex = 28;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGenre.Location = new Point(881, 337);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(521, 33);
            textBoxGenre.TabIndex = 36;
            // 
            // labelTitleDetails
            // 
            labelTitleDetails.AutoSize = true;
            labelTitleDetails.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitleDetails.ForeColor = Color.White;
            labelTitleDetails.Location = new Point(881, 23);
            labelTitleDetails.Name = "labelTitleDetails";
            labelTitleDetails.Size = new Size(86, 26);
            labelTitleDetails.TabIndex = 29;
            labelTitleDetails.Text = "Director";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(881, 234);
            label3.Name = "label3";
            label3.Size = new Size(81, 26);
            label3.TabIndex = 35;
            label3.Text = "Runtime";
            // 
            // textBoxRated
            // 
            textBoxRated.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRated.Location = new Point(881, 125);
            textBoxRated.Name = "textBoxRated";
            textBoxRated.Size = new Size(521, 33);
            textBoxRated.TabIndex = 30;
            // 
            // textBoxRuntime
            // 
            textBoxRuntime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRuntime.Location = new Point(881, 266);
            textBoxRuntime.Name = "textBoxRuntime";
            textBoxRuntime.Size = new Size(521, 33);
            textBoxRuntime.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(881, 93);
            label1.Name = "label1";
            label1.Size = new Size(63, 26);
            label1.TabIndex = 31;
            label1.Text = "Rated";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(881, 164);
            label2.Name = "label2";
            label2.Size = new Size(89, 26);
            label2.TabIndex = 33;
            label2.Text = "Released";
            // 
            // textBoxReleased
            // 
            textBoxReleased.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxReleased.Location = new Point(881, 196);
            textBoxReleased.Name = "textBoxReleased";
            textBoxReleased.Size = new Size(521, 33);
            textBoxReleased.TabIndex = 32;
            // 
            // buttonDelFavorites
            // 
            buttonDelFavorites.BackColor = Color.Olive;
            buttonDelFavorites.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelFavorites.ForeColor = Color.White;
            buttonDelFavorites.Location = new Point(34, 313);
            buttonDelFavorites.Name = "buttonDelFavorites";
            buttonDelFavorites.Size = new Size(181, 38);
            buttonDelFavorites.TabIndex = 24;
            buttonDelFavorites.Text = "Delete from Favorites";
            buttonDelFavorites.UseVisualStyleBackColor = false;
            buttonDelFavorites.Click += buttonDelFavorites_Click;
            // 
            // FormFavorites
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1729, 1061);
            Controls.Add(buttonDelFavorites);
            Controls.Add(pictureBoxFavoritePoster);
            Controls.Add(listBoxFavorites);
            Controls.Add(gp_SearchFavorites);
            Controls.Add(labelHeader_Favorites);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormFavorites";
            Text = "[FormTitleDetails]";
            Load += FormFavorites_Load;
            Paint += FormFavorites_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFavoritePoster).EndInit();
            gp_SearchFavorites.ResumeLayout(false);
            gp_SearchFavorites.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader_Favorites;
        private PictureBox pictureBoxFavoritePoster;
        private ListBox listBoxFavorites;
        private GroupBox gp_SearchFavorites;
        private Button buttonDelFavorites;
        private Label labelFavoritePoster;
        private Label label5;
        private TextBox textBoxPlot;
        private Label label4;
        private TextBox textBoxDirector;
        private TextBox textBoxGenre;
        private Label labelTitleDetails;
        private Label label3;
        private TextBox textBoxRated;
        private TextBox textBoxRuntime;
        private Label label1;
        private Label label2;
        private TextBox textBoxReleased;
    }
}