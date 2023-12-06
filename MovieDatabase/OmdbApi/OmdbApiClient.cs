using Microsoft.Extensions.Configuration;
using MovieDatabase.TmdbApi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;


namespace MovieDatabase.OmdbApi {
    internal class OmdbApiClient {

        private string? omdbApiKey;


        public OmdbApiClient() {
            //Set Credentials from Environment Variables
            IConfigurationRoot config = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            omdbApiKey = config["OMDB_APIKEY"];
        }


        public async Task<T> MakeOmdbRequest<T>(string _queryString) {

            HttpClient httpClient;
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://www.omdbapi.com");

            try {
                using (httpClient) {
                    //API Request
                    using (HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(_queryString)) {
                        using (HttpContent httpContent = httpResponseMessage.Content) {
                            string taskString = await httpContent.ReadAsStringAsync();
                            Object? deserializedObj = JsonConvert.DeserializeObject<T>(taskString);
                            return (T)deserializedObj;
                        }
                    }
                }
            }
            catch (Exception ex) {
                string message = $"[API Error]: {ex.Message}" + Environment.NewLine;
                Debug.WriteLine(message);
                return default(T);
            }
        }



        public async Task<ClassOmdbResponseSearch> GetBySearch(string inputSearchTerm, string inputYear, string inputType) {

            //Build query string
            string queryString = string.Empty;
            queryString += $"/?apikey={omdbApiKey}";                                //API KEY parameter
            queryString += $"&r=json";                                              //The data type to return
            queryString += $"&v=1";                                                 //API version (reserved for future use).
            queryString += $"&s={inputSearchTerm}";                                 //Movie title to search for.
            if (inputYear != null) queryString += $"&y={inputYear}";                  //Year of release.
            if (inputType != null) queryString += $"&type={inputType}";               //Type of result to return.

            ClassOmdbResponseSearch _responseSearch = await MakeOmdbRequest<ClassOmdbResponseSearch>(queryString);
            return _responseSearch;
        }


        public async Task<ClassOmdbTitle> GetByImdbId(string imdbID) {

            //Build query string
            string queryString = string.Empty;
            queryString += $"/?apikey={omdbApiKey}";                                //API KEY parameter
            queryString += $"&r=json";                                              //The data type to return
            queryString += $"&v=1";                                                 //API version (reserved for future use).
            queryString += $"&plot=short";                                          //Return short or full plot.
            queryString += $"&i={imdbID}";                                          //A valid IMDb ID (e.g. tt1285016)

            ClassOmdbTitle _responseTitle = await MakeOmdbRequest<ClassOmdbTitle>(queryString);
            return _responseTitle;
        }
    }
}