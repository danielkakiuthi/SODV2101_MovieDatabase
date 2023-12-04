using MovieDatabase.OmdbApi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.TmdbApi {

    public class ClassTmdbResponse {

        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("results")]
        public List<ClassTmdbTitle> Results { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }


        public override string ToString() {

            string output = string.Empty;
            output += $"Page: {Page}" + Environment.NewLine;
            output += $"Results: [ " + Environment.NewLine;
            bool _firstItem = true;
            foreach (var item in Results) {
                if (_firstItem) {
                    output += item.ToString() + Environment.NewLine;
                }
                else {
                    output += $" | {item.ToString()}" + Environment.NewLine;
                }
            }
            output += $" ]" + Environment.NewLine;
            output += $"Total Pages: {TotalPages}" + Environment.NewLine;
            output += $"Total Results: {TotalResults}" + Environment.NewLine;

            return output;
        }
    }
}
