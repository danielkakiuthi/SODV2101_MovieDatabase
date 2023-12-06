using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.TmdbApi {


        public class Belongs_To_Collection {
            [JsonProperty("id")]
            public int? Id { get; set; }
            [JsonProperty("name")]
            public string? Name { get; set; }
            [JsonProperty("poster_path")]
            public string? PosterPath { get; set; }
            [JsonProperty("backdrop_path")]
            public string? BackdropPath { get; set; }
        }

        public class Genre {
            [JsonProperty("id")]
            public int? Id { get; set; }
            [JsonProperty("name")]
            public string? Name { get; set; }
        }

        public class Production_Companies {
            [JsonProperty("id")]
            public int? Id { get; set; }
            [JsonProperty("logo_path")]
            public string? LogoPath { get; set; }
            [JsonProperty("name")]
            public string? Name { get; set; }
            [JsonProperty("origin_country")]
            public string? OriginCountry { get; set; }
        }

        public class Production_Countries {
            [JsonProperty("iso_3166_1")]
            public string? Iso_3166_1 { get; set; }
            [JsonProperty("name")]
            public string? Name { get; set; }
        }

        public class Spoken_Languages {
            [JsonProperty("english_name")]
            public string? EnglishName { get; set; }
            [JsonProperty("iso_639_1")]
            public string? Iso_639_1 { get; set; }
            [JsonProperty("name")]
            public string? Name { get; set; }
        }


    public class ClassTmdbMovieDetailsResponse {

        [JsonProperty("adult")]
        public bool? Adult { get; set; }
        [JsonProperty("backdrop_path")]
        public string? BackdropPath { get; set; }
        [JsonProperty("belongs_to_collection")]
        public Belongs_To_Collection? BelongsToCollection { get; set; }
        [JsonProperty("budget")]
        public int? Budget { get; set; }
        [JsonProperty("genres")]
        public Genre[]? Genres { get; set; }
        [JsonProperty("homepage")]
        public string? Homepage { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("imdb_id")]
        public string? ImdbId { get; set; }
        [JsonProperty("original_language")]
        public string? OriginalLanguage { get; set; }
        [JsonProperty("original_title")]
        public string? OriginalTitle { get; set; }
        [JsonProperty("overview")]
        public string? Overview { get; set; }
        [JsonProperty("popularity")]
        public float? Popularity { get; set; }
        [JsonProperty("poster_path")]
        public string? PosterPath { get; set; }
        [JsonProperty("production_companies")]
        public Production_Companies[]? ProductionCompanies { get; set; }
        [JsonProperty("production_countries")]
        public Production_Countries[]? ProductionCountries { get; set; }
        [JsonProperty("release_date")]
        public string? ReleaseDate { get; set; }
        [JsonProperty("revenue")]
        public int? Revenue { get; set; }
        [JsonProperty("runtime")]
        public int? Runtime { get; set; }
        [JsonProperty("spoken_languages")]
        public Spoken_Languages[]? SpokenLanguages { get; set; }
        [JsonProperty("status")]
        public string? Status { get; set; }
        [JsonProperty("tagline")]
        public string? Tagline { get; set; }
        [JsonProperty("title")]
        public string? Title { get; set; }
        [JsonProperty("video")]
        public bool? Video { get; set; }
        [JsonProperty("vote_average")]
        public float? VoteAverage { get; set; }
        [JsonProperty("vote_count")]
        public int? VoteCount { get; set; }



        public override string ToString() {

            string output = string.Empty;
            output += $"Id: {Id}" + Environment.NewLine;
            output += $"ImdbId: {ImdbId}" + Environment.NewLine;
            output += $"Title: {Title}" + Environment.NewLine;
            output += $"VoteAverage: {VoteAverage}" + Environment.NewLine;
            output += $"VoteCount: {VoteCount}" + Environment.NewLine;

            return output;
        }
    }
}
