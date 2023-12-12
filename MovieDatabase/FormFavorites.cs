using MovieDatabase.OmdbApi;
using MovieDatabase.SqlClient;
using System.Drawing.Drawing2D;



namespace MovieDatabase {
    public partial class FormFavorites : Form
    {

        public string KeywordQuery { get; set; }
        public string GenreQuery { get; set; }
        public int YearQuery { get; set; }
        public string RatingQuery { get; set; }
        private readonly OmdbApiClient omdbApiClient;
        private readonly List<ClassOmdbTitle> listFavorites;
        private ClassUser myUserLogged;
        public ClassSqlClient mySqlClient { get; set; }



        public FormFavorites(ClassUser userLogged)
        {
            mySqlClient = new ClassSqlClient();
            myUserLogged = userLogged;
            omdbApiClient = new OmdbApiClient();
            listFavorites = new List<ClassOmdbTitle>();

            InitializeComponent();
            UpdateFavoriteList(myUserLogged.Id);
            this.Refresh();
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



        public async Task UpdateFavoriteList(int userId)
        {
            listFavorites.Clear();
            listBoxFavorites.BeginUpdate();
            listBoxFavorites.DataSource = null;
            listBoxFavorites.Items.Clear();

            string selectQuery = $"SELECT imdbID FROM dbo.Favorites WHERE id = {userId}";

            try
            {
                List<string> favoritesFromDatabase = await mySqlClient.GetFavoriteListFromDatabase(selectQuery);

                foreach (var favorite in favoritesFromDatabase)
                {
                    ClassOmdbTitle selectedTitle = await omdbApiClient.GetByImdbId(favorite);
                    listFavorites.Add(selectedTitle);
                }

                listBoxFavorites.DataSource = listFavorites;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating favorites list: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                listBoxFavorites.EndUpdate();
            }
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

                string deleteQuery = $"DELETE FROM dbo.Favorites WHERE id = {myUserLogged.Id} AND ImdbID = '{selectedTitle.ImdbID}'";

                if(mySqlClient.RemoveMovieFromFavorites(deleteQuery)) {
                    MessageBox.Show($"[Movie Removed from Favorites] {selectedTitle.Title} removed from favorites");
                }
            }
        }

        private void FormFavorites_Load(object sender, EventArgs e)
        {

        }
    }
}
