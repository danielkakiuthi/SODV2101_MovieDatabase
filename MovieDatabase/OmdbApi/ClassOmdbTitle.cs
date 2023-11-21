using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.OmdbApi
{

    public class ClassRating {

        public string Source { get; set; }
        public string Value { get; set; }

        public ClassRating(string source, string value) {
            Source = source;
            Value = value;
        }
    }



    public class ClassOmdbTitle {

        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public List<ClassRating> Ratings { get; set; }
        public string Metascore { get; set; }
        public string ImdbRating { get; set; }
        public string ImdbVotes { get; set; }
        public string ImdbID { get; set; }
        public string Type { get; set; }
        public string Dvd { get; set; }
        public string BoxOffice { get; set; }
        public string Production { get; set; }
        public string Website { get; set; }
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
