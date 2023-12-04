using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.OmdbApi {
    public class ClassOmdbResponseSearch {

        [JsonProperty("Search")]
        public List<ClassOmdbTitle> Search { get; set; }
        [JsonProperty("totalResults")]
        public string totalResults { get; set; }
        [JsonProperty("Response")]
        public string Response { get; set; }


        public override string ToString() {

            string result = string.Empty;
            result += $"Search: {Search}" + Environment.NewLine;
            result += $"Total Results: {totalResults}" + Environment.NewLine;
            result += $"Response: {Response}" + Environment.NewLine;

            return result;
        }
    }
}
