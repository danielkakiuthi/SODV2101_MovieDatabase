using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieDatabase.OmdbApi;
using MovieDatabase.TmdbApi;

namespace MovieDatabase {
    public partial class FormHomepage : Form {

        private TmdbApiClient tmdbApiClient;
        private ClassTmdbResponse myResponse;

        public FormHomepage() {
            InitializeComponent();
            tmdbApiClient = new TmdbApiClient();

            //Adjust TableLayoutPanelTopRated
            tableLayoutPanelTopRated.ColumnCount = 10;

        }

        public async void Form1_Load(object sender, EventArgs e) {

            myResponse = await tmdbApiClient.GetTopRated();
            //Debug.WriteLine(myResponse.ToString());
            listBoxTopRated_Homepage.DataSource = myResponse?.Results;

            string message = string.Empty;
            if (myResponse.Results == null) {
                MessageBox.Show("No Title found. Try another search term.");
            }

            List<string> listImageUrls = new List<string>();
            foreach (ClassTmdbTitle c in myResponse.Results) {
                listImageUrls.Add($"https://image.tmdb.org/t/p/w500/{c.PosterPath}");
            }

            for (int i = 0; i < tableLayoutPanelTopRated.ColumnCount; i++) {
                PictureBox newPictureBox = new PictureBox() {
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                newPictureBox.Load(listImageUrls[i]);
                tableLayoutPanelTopRated.Controls.Add(newPictureBox, i, 0);
            }
        }
    }
}
