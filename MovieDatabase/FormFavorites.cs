using MovieDatabase.OmdbApi;
using MovieDatabase.TmdbApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase {
    public partial class FormFavorites : Form
    {

        public string KeywordQuery { get; set; }
        public string GenreQuery { get; set; }
        public int YearQuery { get; set; }
        public string RatingQuery { get; set; }
        private readonly List<ClassOmdbTitle> listFavorites;
        private ClassUser myUserLogged;
        private readonly OmdbApiClient omdbApiClient;
        public string ConnectionString { get; set; }
        ErrorProvider myErrorProvider { get; set; }
        List<string> imdbIdList = new List<string>();


        public FormFavorites(string connectionString, ClassUser userLogged)
        {
            InitializeComponent();
            ConnectionString = connectionString;
            myUserLogged = userLogged;
            omdbApiClient = new OmdbApiClient();
            myErrorProvider = new ErrorProvider();
            listFavorites = new List<ClassOmdbTitle>();
            UpdateFavoriteList(myUserLogged.Id);
        }

        private void FormFavorites_Paint(object sender, PaintEventArgs e)
        {
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

        private void FormFavorites_Load(object sender, EventArgs e)
        {

        }
        public async void UpdateFavoriteList(int userId)
        {
            string selectQuery = "SELECT imdbID FROM dbo.Favorites WHERE id = @userId";


            // Opcionalmente, se você quiser garantir que a exibição seja atualizada
            listBoxFavorites.BeginUpdate();
            listBoxFavorites.DataBindings.Clear();

            try
            {
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(selectQuery, cnn))
                    {
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@userId", userId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string imdbId = reader["imdbID"].ToString();
                                ClassOmdbTitle selectedTitle = await omdbApiClient.GetByImdbId(imdbId);
                                listFavorites.Add(selectedTitle);
                                //UpdateListBox(imdbId);
                                //imdbIdList.Add(imdbId);
                            }
                        }
                        cnn.Close();
                    }
                }
                listBoxFavorites.DataSource = listFavorites;
            }
            finally
            {
                listBoxFavorites.EndUpdate();
            }
            UpdateListBox();
        }

        private async void UpdateListBox()
        {
            /*listBoxFavorites.BeginUpdate();
            ClassOmdbTitle selectedTitle = await omdbApiClient.GetByImdbId(imdbId);
            listFavorites.Add(selectedTitle);
            listBoxFavorites.EndUpdate();*/
            listBoxFavorites.Refresh();

        }
        private async void listBoxFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
             textBoxDirector.Text = string.Empty;
            textBoxRated.Text = string.Empty;
            textBoxReleased.Text = string.Empty;
            textBoxRuntime.Text = string.Empty;
            textBoxGenre.Text = string.Empty;
            textBoxPlot.Text = string.Empty;

            if (listBoxFavorites.SelectedIndex >= 0)
            {
                string? imdbID = (listBoxFavorites.SelectedItem as ClassOmdbTitle)?.ImdbID;

                if (imdbID != null)
                {
                    ClassOmdbTitle selectedFavorite = await omdbApiClient.GetByImdbId(imdbID);

                    textBoxDirector.Text += $"{selectedFavorite.Director}";
                    textBoxRated.Text += $"{selectedFavorite.Rated}";
                    textBoxReleased.Text += $"{selectedFavorite.Released}";
                    textBoxRuntime.Text += $"{selectedFavorite.Runtime}";
                    textBoxGenre.Text += $"{selectedFavorite.Genre}";
                    textBoxPlot.Text += $"{selectedFavorite.Plot}";

                    if (!string.IsNullOrEmpty(selectedFavorite.Poster) && !selectedFavorite.Poster.Equals("N/A"))
                    {
                        pictureBoxFavoritePoster.Load(selectedFavorite.Poster);

                    }
                    else
                    {
                        pictureBoxFavoritePoster.Image = null;
                    }
                }
            }
        }


        private void buttonDelFavorites_Click(object sender, EventArgs e)
        {
            ClassOmdbTitle? selectedTitle = listBoxFavorites.SelectedItem as ClassOmdbTitle;
            if (selectedTitle != null)
            {
                listBoxFavorites.BeginUpdate();
                foreach (var item in listBoxFavorites.Items)
                {
                    if (selectedTitle == item)
                    {
                        int index = listFavorites.IndexOf(selectedTitle);
                        listFavorites.RemoveAt(index); break;
                    }
                }
                listBoxFavorites.DataSource = null;
                listBoxFavorites.DataSource = listFavorites;
                listBoxFavorites.EndUpdate();
                listBoxFavorites.Refresh();
                if (listBoxFavorites.SelectedItem == null)
                {
                    pictureBoxFavoritePoster.Image = null;
                }
                RemoveMovieFromFavorites(selectedTitle.ImdbID, myUserLogged.Id);
            }
        }
        public void RemoveMovieFromFavorites(string imdbID, int userID)
        {
            string deleteQuery = "DELETE FROM dbo.Favorites WHERE id = @userID AND ImdbID = @imdbID";
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, cnn))
                    {
                        cnn.Open();

                        // Use parâmetros para evitar SQL Injection e tratar corretamente valores de texto
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
            //UpdateFavoriteList(userID);
        }

        private void btnUpdateFavorites_Click(object sender, EventArgs e)
        {
            //UpdateListBox();
        }
    }
}
