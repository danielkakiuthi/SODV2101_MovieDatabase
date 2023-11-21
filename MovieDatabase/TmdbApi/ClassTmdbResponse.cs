using MovieDatabase.OmdbApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.TmdbApi {

    public class ClassTmdbResponse {

        public int Page { get; set; }
        public List<ClassTmdbTitle> Results { get; set; }
        public int TotalPages { get; set; }
        public int TotalResults { get; set; }


        public override string ToString() {

            string output = string.Empty;
            output += $"Page: {Page}" + Environment.NewLine;
            output += $"Results: {Results}" + Environment.NewLine;
            output += $"Total Pages: {TotalPages}" + Environment.NewLine;
            output += $"Total Results: {TotalResults}" + Environment.NewLine;

            return output;
        }
    }
}
