using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.TmdbApi {
    public class ClassTmdbTitle {

        [JsonProperty("adult")]
        public bool Adult { get; set; }
        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }
        [JsonProperty("genre_ids")]
        public int[] GenreIds { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }
        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }
        [JsonProperty("overview")]
        public string Overview { get; set; }
        [JsonProperty("popularity")]
        public double Popularity { get; set; }
        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }
        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("video")]
        public bool Video { get; set; }
        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }
        [JsonProperty("vote_count")]
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
