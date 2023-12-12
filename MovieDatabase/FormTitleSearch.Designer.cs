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
            buttonSearch = new Button();
            buttonAddFavorites = new Button();
            textBoxDirector = new TextBox();
            labelTitleDetails = new Label();
            labelTitlePoster = new Label();
            pictureBoxTitlePoster = new PictureBox();
            comboBoxInputType = new ComboBox();
            labelHeader_TitleSearch = new Label();
            groupBox1 = new GroupBox();
            buttonMoreInfo = new Button();
            label5 = new Label();
            textBoxPlot = new TextBox();
            label4 = new Label();
            textBoxGenre = new TextBox();
            label3 = new Label();
            textBoxRuntime = new TextBox();
            label2 = new Label();
            textBoxReleased = new TextBox();
            label1 = new Label();
            textBoxRated = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitlePoster).BeginInit();
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
            labelInputSearch.TabIndex = 2;
            labelInputSearch.Text = "Search:";
            // 
            // labelInputYear
            // 
            labelInputYear.AutoSize = true;
            labelInputYear.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelInputYear.ForeColor = Color.White;
            labelInputYear.Location = new Point(371, 56);
            labelInputYear.Name = "labelInputYear";
            labelInputYear.Size = new Size(131, 23);
            labelInputYear.TabIndex = 4;
            labelInputYear.Text = "Year of Release:";
            // 
            // labelInputType
            // 
            labelInputType.AutoSize = true;
            labelInputType.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelInputType.ForeColor = Color.White;
            labelInputType.Location = new Point(768, 56);
            labelInputType.Name = "labelInputType";
            labelInputType.Size = new Size(52, 23);
            labelInputType.TabIndex = 6;
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
            textBoxInputYear.Location = new Point(508, 50);
            textBoxInputYear.Name = "textBoxInputYear";
            textBoxInputYear.Size = new Size(195, 29);
            textBoxInputYear.TabIndex = 5;
            // 
            // labelSearchResults
            // 
            labelSearchResults.AutoSize = true;
            labelSearchResults.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSearchResults.ForeColor = Color.White;
            labelSearchResults.Location = new Point(29, 25);
            labelSearchResults.Name = "labelSearchResults";
            labelSearchResults.Size = new Size(143, 26);
            labelSearchResults.TabIndex = 8;
            labelSearchResults.Text = "Search Results";
            // 
            // listBoxResponseSearch
            // 
            listBoxResponseSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxResponseSearch.FormattingEnabled = true;
            listBoxResponseSearch.ItemHeight = 25;
            listBoxResponseSearch.Location = new Point(29, 57);
            listBoxResponseSearch.Name = "listBoxResponseSearch";
            listBoxResponseSearch.Size = new Size(406, 654);
            listBoxResponseSearch.TabIndex = 9;
            listBoxResponseSearch.SelectedIndexChanged += listBoxResponseSearch_SelectedIndexChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Green;
            buttonSearch.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(1304, 44);
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
            buttonAddFavorites.Location = new Point(511, 733);
            buttonAddFavorites.Name = "buttonAddFavorites";
            buttonAddFavorites.Size = new Size(181, 38);
            buttonAddFavorites.TabIndex = 23;
            buttonAddFavorites.Text = "Add to Favorites";
            buttonAddFavorites.UseVisualStyleBackColor = false;
            buttonAddFavorites.Click += buttonAddFavorites_Click;
            // 
            // textBoxDirector
            // 
            textBoxDirector.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDirector.Location = new Point(991, 57);
            textBoxDirector.Name = "textBoxDirector";
            textBoxDirector.Size = new Size(521, 33);
            textBoxDirector.TabIndex = 12;
            // 
            // labelTitleDetails
            // 
            labelTitleDetails.AutoSize = true;
            labelTitleDetails.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitleDetails.ForeColor = Color.White;
            labelTitleDetails.Location = new Point(991, 25);
            labelTitleDetails.Name = "labelTitleDetails";
            labelTitleDetails.Size = new Size(86, 26);
            labelTitleDetails.TabIndex = 11;
            labelTitleDetails.Text = "Director";
            // 
            // labelTitlePoster
            // 
            labelTitlePoster.AutoSize = true;
            labelTitlePoster.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitlePoster.ForeColor = Color.White;
            labelTitlePoster.Location = new Point(488, 25);
            labelTitlePoster.Name = "labelTitlePoster";
            labelTitlePoster.Size = new Size(114, 26);
            labelTitlePoster.TabIndex = 10;
            labelTitlePoster.Text = "Title Poster";
            // 
            // pictureBoxTitlePoster
            // 
            pictureBoxTitlePoster.BackColor = Color.Transparent;
            pictureBoxTitlePoster.Location = new Point(488, 57);
            pictureBoxTitlePoster.Name = "pictureBoxTitlePoster";
            pictureBoxTitlePoster.Size = new Size(470, 654);
            pictureBoxTitlePoster.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTitlePoster.TabIndex = 18;
            pictureBoxTitlePoster.TabStop = false;
            // 
            // comboBoxInputType
            // 
            comboBoxInputType.FormattingEnabled = true;
            comboBoxInputType.Items.AddRange(new object[] { "movie", "series", "episode" });
            comboBoxInputType.Location = new Point(847, 50);
            comboBoxInputType.Name = "comboBoxInputType";
            comboBoxInputType.Size = new Size(195, 29);
            comboBoxInputType.TabIndex = 7;
            // 
            // labelHeader_TitleSearch
            // 
            labelHeader_TitleSearch.AutoSize = true;
            labelHeader_TitleSearch.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelHeader_TitleSearch.ForeColor = Color.White;
            labelHeader_TitleSearch.Location = new Point(12, 9);
            labelHeader_TitleSearch.Name = "labelHeader_TitleSearch";
            labelHeader_TitleSearch.Size = new Size(161, 35);
            labelHeader_TitleSearch.TabIndex = 1;
            labelHeader_TitleSearch.Text = "Title Search";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(buttonMoreInfo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxPlot);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pictureBoxTitlePoster);
            groupBox1.Controls.Add(textBoxGenre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxRuntime);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxReleased);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxRated);
            groupBox1.Controls.Add(labelSearchResults);
            groupBox1.Controls.Add(labelTitlePoster);
            groupBox1.Controls.Add(buttonAddFavorites);
            groupBox1.Controls.Add(labelTitleDetails);
            groupBox1.Controls.Add(listBoxResponseSearch);
            groupBox1.Controls.Add(textBoxDirector);
            groupBox1.Location = new Point(38, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1592, 791);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // buttonMoreInfo
            // 
            buttonMoreInfo.BackColor = Color.DarkGreen;
            buttonMoreInfo.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMoreInfo.ForeColor = Color.White;
            buttonMoreInfo.Location = new Point(740, 733);
            buttonMoreInfo.Name = "buttonMoreInfo";
            buttonMoreInfo.Size = new Size(181, 38);
            buttonMoreInfo.TabIndex = 24;
            buttonMoreInfo.Text = "More Info";
            buttonMoreInfo.UseVisualStyleBackColor = false;
            buttonMoreInfo.Click += buttonMoreInfo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(991, 377);
            label5.Name = "label5";
            label5.Size = new Size(45, 26);
            label5.TabIndex = 21;
            label5.Text = "Plot";
            // 
            // textBoxPlot
            // 
            textBoxPlot.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPlot.Location = new Point(991, 409);
            textBoxPlot.Multiline = true;
            textBoxPlot.Name = "textBoxPlot";
            textBoxPlot.Size = new Size(521, 302);
            textBoxPlot.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(991, 307);
            label4.Name = "label4";
            label4.Size = new Size(64, 26);
            label4.TabIndex = 19;
            label4.Text = "Genre";
            // 
            // textBoxGenre
            // 
            textBoxGenre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGenre.Location = new Point(991, 339);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(521, 33);
            textBoxGenre.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(991, 236);
            label3.Name = "label3";
            label3.Size = new Size(81, 26);
            label3.TabIndex = 17;
            label3.Text = "Runtime";
            // 
            // textBoxRuntime
            // 
            textBoxRuntime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRuntime.Location = new Point(991, 268);
            textBoxRuntime.Name = "textBoxRuntime";
            textBoxRuntime.Size = new Size(521, 33);
            textBoxRuntime.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(991, 166);
            label2.Name = "label2";
            label2.Size = new Size(89, 26);
            label2.TabIndex = 15;
            label2.Text = "Released";
            // 
            // textBoxReleased
            // 
            textBoxReleased.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxReleased.Location = new Point(991, 198);
            textBoxReleased.Name = "textBoxReleased";
            textBoxReleased.Size = new Size(521, 33);
            textBoxReleased.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(991, 95);
            label1.Name = "label1";
            label1.Size = new Size(63, 26);
            label1.TabIndex = 13;
            label1.Text = "Rated";
            // 
            // textBoxRated
            // 
            textBoxRated.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRated.Location = new Point(991, 127);
            textBoxRated.Name = "textBoxRated";
            textBoxRated.Size = new Size(521, 33);
            textBoxRated.TabIndex = 14;
            // 
            // FormTitleSearch
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1700, 989);
            Controls.Add(labelHeader_TitleSearch);
            Controls.Add(comboBoxInputType);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxInputYear);
            Controls.Add(textBoxInputSearch);
            Controls.Add(labelInputType);
            Controls.Add(labelInputYear);
            Controls.Add(labelInputSearch);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormTitleSearch";
            Text = "[FormTitleSearch]";
            Load += FormTitleSearch_Load;
            Paint += FormTitleSearch_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitlePoster).EndInit();
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
        private Button buttonSearch;
        private Button buttonAddFavorites;
        private TextBox textBoxDirector;
        private Label labelTitleDetails;
        private Label labelTitlePoster;
        private PictureBox pictureBoxTitlePoster;
        private ComboBox comboBoxInputType;
        private Label labelHeader_TitleSearch;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBoxGenre;
        private Label label3;
        private TextBox textBoxRuntime;
        private Label label2;
        private TextBox textBoxReleased;
        private Label label1;
        private TextBox textBoxRated;
        private Label label5;
        private TextBox textBoxPlot;
        private Button buttonMoreInfo;
    }
}