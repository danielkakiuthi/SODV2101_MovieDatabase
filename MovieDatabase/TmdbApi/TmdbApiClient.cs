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


    }
}





