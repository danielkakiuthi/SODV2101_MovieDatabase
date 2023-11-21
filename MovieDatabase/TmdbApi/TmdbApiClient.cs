using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using MovieDatabase.OmdbApi;

namespace MovieDatabase.TmdbApi {
    internal class TmdbApiClient {

        private string? tmdbApiKey;

        public TmdbApiClient() {
            //Set Credentials from Environment Variables
            IConfigurationRoot config = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            tmdbApiKey = config["TMDB_APIKEY"];
        }


        public async Task<ClassTmdbResponse> GetTopRated() {
            var options = new RestClientOptions("https://api.themoviedb.org/3/movie/top_rated?language=en-US&page=1");

            try {
                using (var client = new RestClient(options)) {
                    RestRequest request = new RestRequest("");
                    request.AddHeader("accept", "application/json");
                    request.AddHeader("Authorization", $"Bearer {tmdbApiKey}");
                    var response = await client.GetAsync(request);

                    Debug.WriteLine($"{response.Content}");

                    ClassTmdbResponse? deserializedObj = JsonConvert.DeserializeObject<ClassTmdbResponse>(response.Content);
                    return deserializedObj;
                }
            }
            catch (Exception ex) {
                string message = $"[API Error]: {ex.Message}" + Environment.NewLine;
                Debug.WriteLine(message);
                return null;
            }


        }


        public async Task<ClassOmdbResponseSearch> GetBySearch(string inputSearchTerm, string inputYear, string inputType) {
            HttpClient httpClient;
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://www.omdbapi.com");
            Debug.WriteLine($"API Key: {tmdbApiKey}");

            try {
                using (httpClient) {
                    //Build query string
                    string queryString = string.Empty;
                    queryString += $"/?apikey={tmdbApiKey}";                                //API KEY parameter
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

    }
}





