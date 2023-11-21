using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.TmdbApi {
    public class ClassTmdbTitle {

        public bool Adult { get; set; }
        public string BackdropPath { get; set; }
        public int[] GenreIds { get; set; }
        public int Id { get; set; }
        public string OriginalLanguage { get; set; }
        public string OriginalTitle { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        public string PosterPath { get; set; }
        public string ReleaseDate { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }
        public double VoteAverage { get; set; }
        public int VoteCount { get; set; }


        public ClassTmdbTitle(bool adult, string backdrop_path, int[] genre_ids, int id, string original_language, string original_title, string overview, double popularity, string poster_path, string release_date, string title, bool video, double vote_average, int vote_count) {

            Adult = adult;
            BackdropPath = backdrop_path;
            GenreIds = genre_ids;
            Id = id;
            OriginalLanguage = original_language;
            OriginalTitle = original_title;
            Overview = overview;
            Popularity = popularity;
            PosterPath = poster_path;
            ReleaseDate = release_date;
            Title = title;
            Video = video;
            VoteAverage = vote_average;
            VoteCount = vote_count;
        }


        public override string ToString() {
            return $"{Title} ({ReleaseDate})";
        }
    }
}
