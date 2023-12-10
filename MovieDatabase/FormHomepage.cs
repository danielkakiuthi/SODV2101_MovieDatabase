using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MovieDatabase.OmdbApi;
using MovieDatabase.TmdbApi;



namespace MovieDatabase {
    public partial class FormHomepage : Form {

        private TmdbApiClient tmdbApiClient;
        private ClassTmdbMovieListResponse myNowPlayingResponse;
        private ClassTmdbMovieListResponse myTopRatedResponse;
        private ClassTmdbMovieListResponse myPopularResponse;
        private ClassTmdbMovieListResponse myUpcomingResponse;
        private OmdbApiClient omdbApiClient;


        public FormHomepage(int width) {
            InitializeComponent();
            tmdbApiClient = new TmdbApiClient();
            omdbApiClient = new OmdbApiClient();

            //Adjust tableLayoutPanelNowPlaying
            labelNowPlaying_Homepage.Location = new Point(10, 10);
            tableLayoutPanelNowPlaying.ColumnCount = 10;
            tableLayoutPanelNowPlaying.Size = new Size(width - 30, 180);
            tableLayoutPanelNowPlaying.Location = new Point(10, 60);

            //Adjust TableLayoutPanelPopular
            labelTopRated_Homepage.Location = new Point(10, 270);
            tableLayoutPanelTopRated.ColumnCount = 10;
            tableLayoutPanelTopRated.Size = new Size(width - 30, 180);
            tableLayoutPanelTopRated.Location = new Point(10, 320);

            //Adjust tableLayoutPanelPopular
            labelPopular_Homepage.Location = new Point(10, 520);
            tableLayoutPanelPopular.ColumnCount = 10;
            tableLayoutPanelPopular.Size = new Size(width - 30, 180);
            tableLayoutPanelPopular.Location = new Point(10, 570);

            //Adjust TableLayoutPanelUpcoming
            labelUpcoming_Homepage.Location = new Point(10, 770);
            tableLayoutPanelUpcoming.ColumnCount = 10;
            tableLayoutPanelUpcoming.Size = new Size(width - 30, 180);
            tableLayoutPanelUpcoming.Location = new Point(10, 820);

        }


        public async void FormHomepage_Load(object sender, EventArgs e) {

            this.SuspendLayout();

            //get data of lists of titles from API
            myNowPlayingResponse = await tmdbApiClient.GetNowPlaying();
            myTopRatedResponse = await tmdbApiClient.GetTopRated();
            myPopularResponse = await tmdbApiClient.GetPopular();
            myUpcomingResponse = await tmdbApiClient.GetUpcoming();


            //check data in responses
            //Debug.WriteLine($"myNowPlayingResponse: {myNowPlayingResponse}");
            //Debug.WriteLine($"myTopRatedResponse: {myTopRatedResponse}");
            //Debug.WriteLine($"myPopularResponse: {myPopularResponse}");
            //Debug.WriteLine($"myUpcomingResponse: {myUpcomingResponse}");


            //Check for errors
            /*if (myNowPlayingResponse.Results == null) {
                MessageBox.Show("[ERROR] No Now Playing Title found.");
            }
            if (myTopRatedResponse.Results == null) {
                MessageBox.Show("[ERROR] No Top Rated Title found.");
            }
            if (myPopularResponse.Results == null) {
                MessageBox.Show("[ERROR] No Popular Title found.");
            }
            if (myUpcomingResponse.Results == null) {
                MessageBox.Show("[ERROR] No Upcoming Title found.");
            }


            //Create lists of URL to display posters in Homepage
            List<string> listNowPlayingImageUrls = new List<string>();
            foreach (ClassTmdbTitle c in myNowPlayingResponse.Results) {
                listNowPlayingImageUrls.Add($"https://image.tmdb.org/t/p/w200/{c.PosterPath}");
            }
            List<string> listTopRatedImageUrls = new List<string>();
            foreach (ClassTmdbTitle c in myTopRatedResponse.Results) {
                listTopRatedImageUrls.Add($"https://image.tmdb.org/t/p/w200/{c.PosterPath}");
            }
            List<string> listPopularImageUrls = new List<string>();
            foreach (ClassTmdbTitle c in myPopularResponse.Results) {
                listPopularImageUrls.Add($"https://image.tmdb.org/t/p/w200/{c.PosterPath}");
            }
            List<string> listUpcomingImageUrls = new List<string>();
            foreach (ClassTmdbTitle c in myUpcomingResponse.Results) {
                listUpcomingImageUrls.Add($"https://image.tmdb.org/t/p/w200/{c.PosterPath}");
            }


            //Populate controls inside Homepage
            for (int i = 0; i < tableLayoutPanelNowPlaying.ColumnCount; i++) {
                PictureBox newPictureBox = new PictureBox() {
                    Size = new Size((int)(tableLayoutPanelNowPlaying.Size.Width * 0.95 / tableLayoutPanelNowPlaying.ColumnCount), 180),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                newPictureBox.LoadAsync(listNowPlayingImageUrls[i]);
                newPictureBox.MouseClick += new MouseEventHandler(NowPlayingTitle_ClickOn);
                tableLayoutPanelNowPlaying.Controls.Add(newPictureBox, i, 0);
            }
            for (int i = 0; i < tableLayoutPanelTopRated.ColumnCount; i++) {
                PictureBox newPictureBox = new PictureBox() {
                    Size = new Size((int)(tableLayoutPanelTopRated.Size.Width * 0.95 / tableLayoutPanelTopRated.ColumnCount), 180),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                newPictureBox.LoadAsync(listTopRatedImageUrls[i]);
                newPictureBox.MouseClick += new MouseEventHandler(TopRatedTitle_ClickOn);
                tableLayoutPanelTopRated.Controls.Add(newPictureBox, i, 0);
            }
            for (int i = 0; i < tableLayoutPanelPopular.ColumnCount; i++) {
                PictureBox newPictureBox = new PictureBox() {
                    Size = new Size((int)(tableLayoutPanelPopular.Size.Width * 0.95 / tableLayoutPanelPopular.ColumnCount), 180),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                newPictureBox.LoadAsync(listPopularImageUrls[i]);
                newPictureBox.MouseClick += new MouseEventHandler(PopularTitle_ClickOn);
                tableLayoutPanelPopular.Controls.Add(newPictureBox, i, 0);
            }
            for (int i = 0; i < tableLayoutPanelUpcoming.ColumnCount; i++) {
                PictureBox newPictureBox = new PictureBox() {
                    Size = new Size((int)(tableLayoutPanelUpcoming.Size.Width * 0.95 / tableLayoutPanelUpcoming.ColumnCount), 180),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                newPictureBox.LoadAsync(listUpcomingImageUrls[i]);
                newPictureBox.MouseClick += new MouseEventHandler(UpcomingTitle_ClickOn);
                tableLayoutPanelUpcoming.Controls.Add(newPictureBox, i, 0);
            }*/

            this.ResumeLayout();
        }


        private void FormHomepage_Paint(object sender, PaintEventArgs e) {

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


        public async void NowPlayingTitle_ClickOn(object sender, MouseEventArgs e) {
            
            //TMDB API
            int _row = tableLayoutPanelNowPlaying.GetRow((Control)sender);
            int _column = tableLayoutPanelNowPlaying.GetColumn((Control)sender);
            //Debug.WriteLine($"[TableLayoutPanel NowPlaying] Cell chosen: ({_row}, {_column})");
            string _selectedTmdbTitle = myNowPlayingResponse.Results[_column].ToString();
            //Debug.WriteLine($"_selectedTmdbTitle: {_selectedTmdbTitle}");
            int _selectedTmdbId = myNowPlayingResponse.Results[_column].Id;
            //Debug.WriteLine($"_selectedTmdbId: {_selectedTmdbId}");

            //Get imdbId from TMDB API
            ClassTmdbMovieDetailsResponse _selectedTmdbMovieDetails = await tmdbApiClient.GetMovieDetailsById(_selectedTmdbId);
            string _imdbId = _selectedTmdbMovieDetails.ImdbId;
            //Debug.WriteLine($"_imdbId: {_imdbId}");

            //OMDB API
            ClassOmdbTitle _selectedOmdbTitle = await omdbApiClient.GetByImdbId(_imdbId);
            Debug.WriteLine($"_selectedOmdbTitle: {_selectedOmdbTitle}");

            //Open Dialog with Title Details from OMDB API
            FormTitleDetails formTitleDetails = new FormTitleDetails(_selectedOmdbTitle);
            formTitleDetails.ShowDialog();
        }

        public async void TopRatedTitle_ClickOn(object sender, MouseEventArgs e) {

            //TMDB API
            int _row = tableLayoutPanelTopRated.GetRow((Control)sender);
            int _column = tableLayoutPanelTopRated.GetColumn((Control)sender);
            //Debug.WriteLine($"[TableLayoutPanel TopRated] Cell chosen: ({_row}, {_column})");
            int _selectedTmdbId = myTopRatedResponse.Results[_column].Id;
            //Debug.WriteLine($"_selectedTmdbId: {_selectedTmdbId}");

            //Get imdbId from TMDB API
            ClassTmdbMovieDetailsResponse _selectedTmdbMovieDetails = await tmdbApiClient.GetMovieDetailsById(_selectedTmdbId);
            string _imdbId = _selectedTmdbMovieDetails.ImdbId;
            //Debug.WriteLine($"_imdbId: {_imdbId}");

            //OMDB API
            ClassOmdbTitle _selectedOmdbTitle = await omdbApiClient.GetByImdbId(_imdbId);
            Debug.WriteLine($"_selectedOmdbTitle: {_selectedOmdbTitle}");

            //Open Dialog with Title Details from OMDB API
            FormTitleDetails formTitleDetails = new FormTitleDetails(_selectedOmdbTitle);
            formTitleDetails.ShowDialog();
        }

        public async void PopularTitle_ClickOn(object sender, MouseEventArgs e) {

            //TMDB API
            int _row = tableLayoutPanelPopular.GetRow((Control)sender);
            int _column = tableLayoutPanelPopular.GetColumn((Control)sender);
            //Debug.WriteLine($"[TableLayoutPanel Popular] Cell chosen: ({_row}, {_column})");
            int _selectedTmdbId = myPopularResponse.Results[_column].Id;
            //Debug.WriteLine($"_selectedTmdbId: {_selectedTmdbId}");

            //Get imdbId from TMDB API
            ClassTmdbMovieDetailsResponse _selectedTmdbMovieDetails = await tmdbApiClient.GetMovieDetailsById(_selectedTmdbId);
            string _imdbId = _selectedTmdbMovieDetails.ImdbId;
            //Debug.WriteLine($"_imdbId: {_imdbId}");

            //OMDB API
            ClassOmdbTitle _selectedOmdbTitle = await omdbApiClient.GetByImdbId(_imdbId);
            Debug.WriteLine($"_selectedOmdbTitle: {_selectedOmdbTitle}");

            //Open Dialog with Title Details from OMDB API
            FormTitleDetails formTitleDetails = new FormTitleDetails(_selectedOmdbTitle);
            formTitleDetails.ShowDialog();
        }

        public async void UpcomingTitle_ClickOn(object sender, MouseEventArgs e) {

            //TMDB API
            int _row = tableLayoutPanelUpcoming.GetRow((Control)sender);
            int _column = tableLayoutPanelUpcoming.GetColumn((Control)sender);
            //Debug.WriteLine($"[TableLayoutPanel Upcoming] Cell chosen: ({_row}, {_column})");
            int _selectedTmdbId = myUpcomingResponse.Results[_column].Id;
            //Debug.WriteLine($"_selectedTmdbId: {_selectedTmdbId}");

            //Get imdbId from TMDB API
            ClassTmdbMovieDetailsResponse _selectedTmdbMovieDetails = await tmdbApiClient.GetMovieDetailsById(_selectedTmdbId);
            string _imdbId = _selectedTmdbMovieDetails.ImdbId;
            //Debug.WriteLine($"_imdbId: {_imdbId}");

            //OMDB API
            ClassOmdbTitle _selectedOmdbTitle = await omdbApiClient.GetByImdbId(_imdbId);
            Debug.WriteLine($"_selectedOmdbTitle: {_selectedOmdbTitle}");

            //Open Dialog with Title Details from OMDB API
            FormTitleDetails formTitleDetails = new FormTitleDetails(_selectedOmdbTitle);
            formTitleDetails.ShowDialog();
        }
    }
}