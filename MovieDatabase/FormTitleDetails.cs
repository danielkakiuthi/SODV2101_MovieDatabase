using MovieDatabase.OmdbApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase {
    public partial class FormTitleDetails : Form {

        private ClassOmdbTitle myOmdbTitle;


        public FormTitleDetails(ClassOmdbTitle classOmdb) {
            InitializeComponent();
            this.CenterToParent();
            myOmdbTitle = classOmdb;

            textBoxTitle.Text = myOmdbTitle.Title;
            textBoxYear.Text = myOmdbTitle.Year;
            textBoxRated.Text = myOmdbTitle.Rated;
            textBoxReleased.Text = myOmdbTitle.Released;
            textBoxRuntime.Text = myOmdbTitle.Runtime;
            textBoxGenre.Text = myOmdbTitle.Genre;
            textBoxDirector.Text = myOmdbTitle.Director;
            textBoxWriter.Text = myOmdbTitle.Writer;
            textBoxActors.Text = myOmdbTitle.Actors;
            textBoxLanguage.Text = myOmdbTitle.Language;
            textBoxCountry.Text = myOmdbTitle.Country;
            textBoxPlot.Text = myOmdbTitle.Plot;
            textBoxImdbId.Text = myOmdbTitle.ImdbID;
            textBoxImdbRating.Text = myOmdbTitle.ImdbRating;
            textBoxImdbVotes.Text = myOmdbTitle.ImdbVotes;
            textBoxMetascore.Text = myOmdbTitle.Metascore;
            textBoxType.Text = myOmdbTitle.Type;
            textBoxDvd.Text = myOmdbTitle.Dvd;
            textBoxBoxOffice.Text = myOmdbTitle.BoxOffice;
            textBoxProduction.Text = myOmdbTitle.Production;
            textBoxWebsite.Text = myOmdbTitle.Website;
            textBoxAwards.Text = myOmdbTitle.Awards;

            bool _firstRatings = true;
            string _contentRatings = "[ ";
            for (int i = 0; i < myOmdbTitle.Ratings.Count; i++) {
                if (_firstRatings) {
                    _contentRatings += $"{{{myOmdbTitle.Ratings[i]}}}";
                }
                else {
                    _contentRatings += $", {{{myOmdbTitle.Ratings[i]}}}";
                }
            }
            _contentRatings += " ]";
            textBoxRatings.Text = _contentRatings;

            pictureBoxPoster.Load(myOmdbTitle.Poster);
        }



        private void FormTitleDetails_Paint(object sender, PaintEventArgs e) {
            Color c1 = Color.FromArgb(255, 69, 0, 3);
            Color c2 = Color.FromArgb(255, 65, 21, 0);
            Color c3 = Color.FromArgb(255, 56, 36, 0);
            Color c4 = Color.FromArgb(255, 43, 48, 0);
            Color c5 = Color.FromArgb(255, 29, 56, 23);
            Color c6 = Color.FromArgb(255, 13, 63, 45);
            Color c7 = Color.FromArgb(255, 0, 69, 66);

            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, c1, c7, 90, true);
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, (float)0.146, (float)0.317, (float)0.439, (float)0.585, (float)0.797, 1 };
            cb.Colors = new[] { c1, c2, c3, c4, c5, c6, c7 };
            br.InterpolationColors = cb;

            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }

    }
}
