using System.Diagnostics;
using MovieDatabase.TmdbApi;



namespace MovieDatabase {
    public partial class FormHomepage : Form {

        private TmdbApiClient tmdbApiClient;
        private ClassTmdbResponse myTopRatedResponse;
        private ClassTmdbResponse myPopularResponse;
        private ClassTmdbResponse myUpcomingResponse;

        public FormHomepage(int width) {
            InitializeComponent();
            tmdbApiClient = new TmdbApiClient();

            //Adjust TableLayoutPanelTopRated
            tableLayoutPanelTopRated.ColumnCount = 10;
            tableLayoutPanelTopRated.Size = new Size(width, 180);
            tableLayoutPanelTopRated.Location = new Point(10, 100);
            labelTopRated_Homepage.Location = new Point(10, 70);

            //Adjust TableLayoutPanelPopular
            tableLayoutPanelPopular.ColumnCount = 10;
            tableLayoutPanelPopular.Size = new Size(width, 180);
            tableLayoutPanelPopular.Location = new Point(10, 350);
            labelPopular_Homepage.Location = new Point(10, 320);

            //Adjust TableLayoutPanelUpcoming
            tableLayoutPanelUpcoming.ColumnCount = 10;
            tableLayoutPanelUpcoming.Size = new Size(width, 180);
            tableLayoutPanelUpcoming.Location = new Point(10, 600);
            labelUpcoming_Homepage.Location = new Point(10, 570);

        }


        public async void FormHomepage_Load(object sender, EventArgs e) {

            //get data of lists of titles from API
            myTopRatedResponse = await tmdbApiClient.GetTopRated();
            myPopularResponse = await tmdbApiClient.GetPopular();
            myUpcomingResponse = await tmdbApiClient.GetUpcoming();


            //check data in responses
            Debug.WriteLine(myTopRatedResponse.ToString());


            //DEBUG (DELETE LATER)
            listBoxTopRated_Homepage.DataSource = myTopRatedResponse?.Results;


            //Check for errors
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
            for (int i = 0; i < tableLayoutPanelTopRated.ColumnCount; i++) {
                PictureBox newPictureBox = new PictureBox() {
                    Size = new Size((int)(tableLayoutPanelTopRated.Size.Width *0.9 / tableLayoutPanelTopRated.ColumnCount), 200),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                newPictureBox.Load(listTopRatedImageUrls[i]);
                tableLayoutPanelTopRated.Controls.Add(newPictureBox, i, 0);
            }
            for (int i = 0; i < tableLayoutPanelPopular.ColumnCount; i++) {
                PictureBox newPictureBox = new PictureBox() {
                    Size = new Size((int)(tableLayoutPanelPopular.Size.Width*0.9 / tableLayoutPanelPopular.ColumnCount), 200),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                newPictureBox.Load(listPopularImageUrls[i]);
                tableLayoutPanelPopular.Controls.Add(newPictureBox, i, 0);
            }
            for (int i = 0; i < tableLayoutPanelUpcoming.ColumnCount; i++) {
                PictureBox newPictureBox = new PictureBox() {
                    Size = new Size((int)(tableLayoutPanelUpcoming.Size.Width*0.9 / tableLayoutPanelUpcoming.ColumnCount), 200),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                newPictureBox.Load(listUpcomingImageUrls[i]);
                tableLayoutPanelUpcoming.Controls.Add(newPictureBox, i, 0);
            }
        }

    }
}