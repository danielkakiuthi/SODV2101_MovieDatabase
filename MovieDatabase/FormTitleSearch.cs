﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieDatabase.OmdbApi;

namespace MovieDatabase
{
    public partial class FormTitleSearch : Form {

        private ClassOmdbResponseSearch? myResponse;
        private readonly OmdbApiClient omdbApiClient;
        private readonly List<ClassOmdbTitle> listFavorites;


        public FormTitleSearch() {
            InitializeComponent();
            omdbApiClient = new OmdbApiClient();
            listFavorites = new List<ClassOmdbTitle>();
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
                textBoxTitleDetails.Text = "No Title found. Try another search term.";
            }
        }


        private void buttonAddFavorites_Click(object sender, EventArgs e) {
            ClassOmdbTitle? selectedTitle = listBoxResponseSearch.SelectedItem as ClassOmdbTitle;
            if (selectedTitle != null) {
                listFavorites.Add(selectedTitle);
                listBoxFavorites.DataSource = null;
                listBoxFavorites.DataSource = listFavorites;
            }
        }


        private async void listBoxResponseSearch_SelectedIndexChanged(object sender, EventArgs e) {
            textBoxTitleDetails.Text = string.Empty;

            if (listBoxResponseSearch.SelectedIndex >= 0) {
                string? imdbId = (listBoxResponseSearch.SelectedItem as ClassOmdbTitle)?.ImdbID;

                if (imdbId != null) {
                    ClassOmdbTitle selectedTitle = await omdbApiClient.GetByImdbId(imdbId);

                    textBoxTitleDetails.Text += $"Director: {selectedTitle.Director}" + Environment.NewLine;
                    textBoxTitleDetails.Text += $"Rated: {selectedTitle.Rated}" + Environment.NewLine;
                    textBoxTitleDetails.Text += $"Released: {selectedTitle.Released}" + Environment.NewLine;
                    textBoxTitleDetails.Text += $"Runtime: {selectedTitle.Runtime}" + Environment.NewLine;
                    textBoxTitleDetails.Text += $"Genre: {selectedTitle.Genre}" + Environment.NewLine;
                    textBoxTitleDetails.Text += $"Plot: {selectedTitle.Plot}";

                    if (!string.IsNullOrEmpty(selectedTitle.Poster) && !selectedTitle.Poster.Equals("N/A")) {
                        pictureBoxTitlePoster.Load(selectedTitle.Poster);
                    }
                    else {
                        pictureBoxTitlePoster.Image = null;
                    }
                }
            }
        }

        private async void listBoxFavorites_SelectedIndexChanged(object sender, EventArgs e) {
            textBoxFavoriteDetails.Text = string.Empty;

            if (listBoxFavorites.SelectedIndex >= 0) {
                string? imdbID = (listBoxFavorites.SelectedItem as ClassOmdbTitle)?.ImdbID;

                if (imdbID != null) {
                    ClassOmdbTitle selectedFavorite = await omdbApiClient.GetByImdbId(imdbID);

                    textBoxFavoriteDetails.Text += $"Director: {selectedFavorite.Director}" + Environment.NewLine;
                    textBoxFavoriteDetails.Text += $"Rated: {selectedFavorite.Rated}" + Environment.NewLine;
                    textBoxFavoriteDetails.Text += $"Released: {selectedFavorite.Released}" + Environment.NewLine;
                    textBoxFavoriteDetails.Text += $"Runtime: {selectedFavorite.Runtime}" + Environment.NewLine;
                    textBoxFavoriteDetails.Text += $"Genre: {selectedFavorite.Genre}" + Environment.NewLine;
                    textBoxFavoriteDetails.Text += $"Plot: {selectedFavorite.Plot}";

                    if (!string.IsNullOrEmpty(selectedFavorite.Poster) && !selectedFavorite.Poster.Equals("N/A")) {
                        pictureBoxFavoritePoster.Load(selectedFavorite.Poster);
                    }
                    else {
                        pictureBoxFavoritePoster.Image = null;
                    }
                }
            }
        }

    }
}
