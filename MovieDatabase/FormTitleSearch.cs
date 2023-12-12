using System.Diagnostics;
using System.Drawing.Drawing2D;
using MovieDatabase.OmdbApi;
using MovieDatabase.SqlClient;



namespace MovieDatabase {
    public partial class FormTitleSearch : Form {

        private ClassSqlClient mySqlClient;
        private readonly OmdbApiClient omdbApiClient;
        private ClassOmdbResponseSearch? myResponse;
        private readonly List<ClassOmdbTitle> listFavorites;
        private ClassUser myUserLogged;
        ErrorProvider myErrorProvider { get; set; }



        public FormTitleSearch(ClassUser userLogged) {
            mySqlClient = new ClassSqlClient();
            myUserLogged = userLogged;
            myErrorProvider = new ErrorProvider();
            omdbApiClient = new OmdbApiClient();
            listFavorites = new List<ClassOmdbTitle>();
            
            InitializeComponent();
        }


        private async void buttonSearch_Click(object sender, EventArgs e) {
            string querySearch = textBoxInputSearch.Text;
            string? queryYear = textBoxInputYear.Text;
            string? queryType = comboBoxInputType.Text;

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

                string insertQuery = "INSERT INTO dbo.Favorites (id, imdbID) ";
                insertQuery += $"VALUES ('{myUserLogged.Id}', '{selectedTitle.ImdbID}'); ";
                
                if (mySqlClient.AddMoviesToFavorites(insertQuery)) {
                    MessageBox.Show($"[Movie Added to Favorites] {selectedTitle.Title} added to favorites");
                }
                else {
                MessageBox.Show($"[ERROR] This movie is already in your list of favorites!");
            }
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


        private void FormTitleSearch_Load(object sender, EventArgs e) {
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

        private async void buttonMoreInfo_Click(object sender, EventArgs e) {

            string? _imdbId = (listBoxResponseSearch.SelectedItem as ClassOmdbTitle)?.ImdbID;

            //OMDB API
            ClassOmdbTitle _selectedOmdbTitle = await omdbApiClient.GetByImdbId(_imdbId);
            Debug.WriteLine($"_selectedOmdbTitle: {_selectedOmdbTitle}");

            //Open Dialog with Title Details from OMDB API
            FormTitleDetails formTitleDetails = new FormTitleDetails(_selectedOmdbTitle, myUserLogged);
            formTitleDetails.ShowDialog();
        }
    }
}
