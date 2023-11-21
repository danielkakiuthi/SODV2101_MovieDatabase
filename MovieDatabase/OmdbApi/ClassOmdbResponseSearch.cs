using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.OmdbApi {
    public class ClassOmdbResponseSearch {

        public List<ClassOmdbTitle> Search { get; set; }
        public string totalResults { get; set; }
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
