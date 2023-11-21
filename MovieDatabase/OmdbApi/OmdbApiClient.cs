using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieDatabase.OmdbApi {
    internal class OmdbApiClient {

        private string omdbApiKey;

        public OmdbApiClient() {
            //Set Credentials from Environment Variables
            IConfigurationRoot config = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            omdbApiKey = config["OMDB_APIKEY"];
        }


        public async Task<ClassOmdbResponseSearch> GetBySearch(string inputSearchTerm, string inputYear, string inputType) {
            HttpClient httpClient;
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://www.omdbapi.com");
            Debug.WriteLine($"API Key: {omdbApiKey}");

            try {
                using (httpClient) {
                    //Build query string
                    string queryString = string.Empty;
                    queryString += $"/?apikey={omdbApiKey}";                                //API KEY parameter
                    queryString += $"&r=json";                                              //The data type to return
                    queryString += $"&v=1";                                                 //API version (reserved for future use).
                    queryString += $"&s={inputSearchTerm}";                                 //Movie title to search for.
                    if (inputYear != null) queryString += $"&y={inputYear}";                  //Year of release.
                    if (inputType != null) queryString += $"&type={inputType}";               //Type of result to return.

                    //API Request
                    using (HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(queryString)) {
                        using (HttpContent httpContent = httpResponseMessage.Content) {
                            string taskString = await httpContent.ReadAsStringAsync();
                            ClassOmdbResponseSearch? deserializedObj = JsonConvert.DeserializeObject<ClassOmdbResponseSearch>(taskString);
                            return deserializedObj;
                        }
                    }
                }
            }
            catch (Exception ex) {
                string message = $"[API Error]: {ex.Message}" + Environment.NewLine;
                Debug.WriteLine(message);
                return null;
            }
        }

        public async Task<ClassOmdbTitle> GetByImdbId(string imdbID) {
            HttpClient httpClient;
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://www.omdbapi.com");

            try {
                using (httpClient) {
                    //Build query string
                    string queryString = string.Empty;
                    queryString += $"/?apikey={omdbApiKey}";                                //API KEY parameter
                    queryString += $"&r=json";                                              //The data type to return
                    queryString += $"&v=1";                                                 //API version (reserved for future use).
                    queryString += $"&plot=short";                                          //Return short or full plot.
                    queryString += $"&i={imdbID}";                                          //A valid IMDb ID (e.g. tt1285016)

                    //API Request
                    using (HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(queryString)) {
                        using (HttpContent httpContent = httpResponseMessage.Content) {
                            string taskString = await httpContent.ReadAsStringAsync();
                            ClassOmdbTitle? deserializedObj = JsonConvert.DeserializeObject<ClassOmdbTitle>(taskString);
                            return deserializedObj;
                        }
                    }
                }
            }
            catch (Exception ex) {
                string message = $"[API Error]: {ex.Message}" + Environment.NewLine;
                Debug.WriteLine(message);
                return null;
            }
        }
    }
}
