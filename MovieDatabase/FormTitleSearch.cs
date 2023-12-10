using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieDatabase.OmdbApi;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace MovieDatabase {
    public partial class FormTitleSearch : Form {

        private ClassOmdbResponseSearch? myResponse;
        private readonly OmdbApiClient omdbApiClient;
        private readonly List<ClassOmdbTitle> listFavorites;
        private ClassUser myUserLogged;
        public string ConnectionString { get; set; }
        ErrorProvider myErrorProvider { get; set; }



        public FormTitleSearch(string connectionString, ClassUser userLogged) {
            InitializeComponent();
            ConnectionString = connectionString;
            myUserLogged = userLogged;
            myErrorProvider = new ErrorProvider();
            omdbApiClient = new OmdbApiClient();
            listFavorites = new List<ClassOmdbTitle>();
            lblFavoriteAdd.Text = "";
        }


        private async void buttonSearch_Click(object sender, EventArgs e) {
            string querySearch = textBoxInputSearch.Text;
            string? queryYear = textBoxInputYear.Text;
            string? queryType = comboBoxInputType.Text;
            lblFavoriteAdd.Text = "";

            myResponse = await omdbApiClient.GetBySearch(querySearch, queryYear, queryType);
            //Debug.WriteLine(myResponse.ToString());
            listBoxResponseSearch.DataSource = myResponse?.Search;

            string message = string.Empty;
            if (myResponse.Search == null) {
                textBoxDirector.Text = "No Title found. Try another search term.";
            }
        }


        private void buttonAddFavorites_Click(object sender, EventArgs e) {
            ClassOmdbTitle? selectedTitle = listBoxResponseSearch.SelectedItem as ClassOmdbTitle;
            if (selectedTitle != null) {
                listFavorites.Add(selectedTitle);             
                AddMoviestoFavorites(selectedTitle.ImdbID, myUserLogged.Id, selectedTitle.Title);
            }
        }

        public void AddMoviestoFavorites(string imdbID, int userID, string title)
        {
            string insertQuery = "INSERT INTO dbo.Favorites (id, imdbID) ";
            insertQuery += $"VALUES ('{userID}', '{imdbID}'); ";
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(insertQuery, cnn))
                    {
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
                lblFavoriteAdd.Text = title + " added to favorites";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[ERROR] Something went wrong!\n{ex.Message}"); ;
            }
        }

        public void RemoveMovieFromFavorites(string imdbID, int userID)
        {
            string deleteQuery = "DELETE FROM dbo.Favorites WHERE id = @userID AND MovieName = @imdbID";
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, cnn))
                    {
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.Parameters.AddWithValue("@imdbID", imdbID);
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[ERROR] Algo deu errado!\n{ex.Message}");
            }
        }


        private async void listBoxResponseSearch_SelectedIndexChanged(object sender, EventArgs e) {
            textBoxDirector.Text = string.Empty;
            textBoxRated.Text = string.Empty;
            textBoxReleased.Text = string.Empty;
            textBoxRuntime.Text = string.Empty;
            textBoxGenre.Text = string.Empty;
            textBoxPlot.Text = string.Empty;
            

            if (listBoxResponseSearch.SelectedIndex >= 0) {
                string? imdbId = (listBoxResponseSearch.SelectedItem as ClassOmdbTitle)?.ImdbID;

                if (imdbId != null) {
                    ClassOmdbTitle selectedTitle = await omdbApiClient.GetByImdbId(imdbId);

                    textBoxDirector.Text += $"{selectedTitle.Director}";
                    textBoxRated.Text += $"{selectedTitle.Rated}";
                    textBoxReleased.Text += $"{selectedTitle.Released}";
                    textBoxRuntime.Text += $"{selectedTitle.Runtime}";
                    textBoxGenre.Text += $"{selectedTitle.Genre}";
                    textBoxPlot.Text += $"{selectedTitle.Plot}";

                    if (!string.IsNullOrEmpty(selectedTitle.Poster) && !selectedTitle.Poster.Equals("N/A")) {
                        pictureBoxTitlePoster.Load(selectedTitle.Poster);
                    }
                    else {
                        pictureBoxTitlePoster.Image = null;
                    }
                }
            }
        }

        private void FormTitleSearch_Load(object sender, EventArgs e) 
        {
            lblFavoriteAdd.Text = "";
        }

        private void Refresh()
        {
            lblFavoriteAdd.Text = "";
        }


        private void FormTitleSearch_Paint(object sender, PaintEventArgs e) {
            Color c1 = Color.FromArgb(255, 0, 3, 88);
            Color c2 = Color.FromArgb(255, 0, 18, 94);
            Color c3 = Color.FromArgb(255, 0, 29, 99);
            Color c4 = Color.FromArgb(255, 0, 39, 103);
            Color c5 = Color.FromArgb(255, 0, 48, 105);
            Color c6 = Color.FromArgb(255, 0, 57, 106);
            Color c7 = Color.FromArgb(255, 10, 65, 107);

            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, c1, c7, 90, true);
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, (float)0.146, (float)0.317, (float)0.439, (float)0.585, (float)0.797, 1 };
            cb.Colors = new[] { c1, c2, c3, c4, c5, c6, c7 };
            br.InterpolationColors = cb;

            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }
    }
}
