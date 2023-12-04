using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.OmdbApi
{

    public class ClassRating {

        [JsonProperty("Source")]
        public string Source { get; set; }
        [JsonProperty("Value")]
        public string Value { get; set; }

        public ClassRating(string source, string value) {
            Source = source;
            Value = value;
        }
    }



    public class ClassOmdbTitle {

        [JsonProperty("Title")]
        public string Title { get; set; }
        [JsonProperty("Year")]
        public string Year { get; set; }
        [JsonProperty("Rated")]
        public string Rated { get; set; }
        [JsonProperty("Released")]
        public string Released { get; set; }
        [JsonProperty("Runtime")]
        public string Runtime { get; set; }
        [JsonProperty("Genre")]
        public string Genre { get; set; }
        [JsonProperty("Director")]
        public string Director { get; set; }
        [JsonProperty("Writer")]
        public string Writer { get; set; }
        [JsonProperty("Actors")]
        public string Actors { get; set; }
        [JsonProperty("Plot")]
        public string Plot { get; set; }
        [JsonProperty("Language")]
        public string Language { get; set; }
        [JsonProperty("Country")]
        public string Country { get; set; }
        [JsonProperty("Awards")]
        public string Awards { get; set; }
        [JsonProperty("Poster")]
        public string Poster { get; set; }
        [JsonProperty("Ratings")]
        public List<ClassRating> Ratings { get; set; }
        [JsonProperty("Metascore")]
        public string Metascore { get; set; }
        [JsonProperty("imdbRating")]
        public string ImdbRating { get; set; }
        [JsonProperty("imdbVotes")]
        public string ImdbVotes { get; set; }
        [JsonProperty("imdbID")]
        public string ImdbID { get; set; }
        [JsonProperty("Type")]
        public string Type { get; set; }
        [JsonProperty("DVD")]
        public string Dvd { get; set; }
        [JsonProperty("BoxOffice")]
        public string BoxOffice { get; set; }
        [JsonProperty("Production")]
        public string Production { get; set; }
        [JsonProperty("Website")]
        public string Website { get; set; }
        [JsonProperty("Response")]
        public string Response { get; set; }


        public ClassOmdbTitle(string title, string year, string rated, string released, string runtime, string genre, string director, string writer, string actors, string plot, string language, string country, string awards, string poster, List<ClassRating> ratings, string metascore, string imdbRating, string imdbVotes, string imdbID, string type, string dvd, string boxOffice, string production, string website, string response) {
            Title = title;
            Year = year;
            Rated = rated;
            Released = released;
            Runtime = runtime;
            Genre = genre;
            Director = director;
            Writer = writer;
            Actors = actors;
            Plot = plot;
            Language = language;
            Country = country;
            Awards = awards;
            Poster = poster;
            Ratings = ratings;
            Metascore = metascore;
            ImdbRating = imdbRating;
            ImdbVotes = imdbVotes;
            ImdbID = imdbID;
            Type = type;
            Dvd = dvd;
            BoxOffice = boxOffice;
            Production = production;
            Website = website;
            Response = response;
        }


        public override string ToString() {
            return $"{Title} ({Year})";
        }
    }
}
