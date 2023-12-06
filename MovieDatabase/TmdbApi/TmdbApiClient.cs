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
using static System.Windows.Forms.Design.AxImporter;

namespace MovieDatabase.TmdbApi {
    internal class TmdbApiClient {

        private string? tmdbApiKey;

        public TmdbApiClient() {
            //Set Credentials from Environment Variables
            IConfigurationRoot config = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            tmdbApiKey = config["TMDB_APIKEY"];
        }


        public async Task<T> MakeTmdbRequest<T>(RestClientOptions _options) {
            try {
                using (var client = new RestClient(_options)) {
                    RestRequest request = new RestRequest("");
                    request.AddHeader("accept", "application/json");
                    request.AddHeader("Authorization", $"Bearer {tmdbApiKey}");
                    var response = await client.GetAsync(request);

                    Debug.WriteLine($"{response.Content}");

                    Object? deserializedObj = JsonConvert.DeserializeObject<T>(response.Content);
                    return (T)deserializedObj;
                }
            }
            catch (Exception ex) {
                string message = $"[API Error]: {ex.Message}" + Environment.NewLine;
                Debug.WriteLine(message);
                return default(T);
            }
        }


        public async Task<ClassTmdbMovieListResponse> GetNowPlaying() {
            var options = new RestClientOptions($"https://api.themoviedb.org/3/movie/now_playing?language=en-US&page=1");
            ClassTmdbMovieListResponse _responseMovieList = await MakeTmdbRequest<ClassTmdbMovieListResponse>(options);
            return _responseMovieList;
        }


        public async Task<ClassTmdbMovieListResponse> GetTopRated() {
            var options = new RestClientOptions($"https://api.themoviedb.org/3/movie/top_rated?language=en-US&page=1");
            ClassTmdbMovieListResponse _responseMovieList = await MakeTmdbRequest<ClassTmdbMovieListResponse>(options);
            return _responseMovieList;
        }


        public async Task<ClassTmdbMovieListResponse> GetPopular() {
            var options = new RestClientOptions($"https://api.themoviedb.org/3/movie/popular?language=en-US&page=1");
            ClassTmdbMovieListResponse _responseMovieList = await MakeTmdbRequest<ClassTmdbMovieListResponse>(options);
            return _responseMovieList;
        }


        public async Task<ClassTmdbMovieListResponse> GetUpcoming() {
            var options = new RestClientOptions($"https://api.themoviedb.org/3/movie/upcoming?language=en-US&page=1");
            ClassTmdbMovieListResponse _responseMovieList = await MakeTmdbRequest<ClassTmdbMovieListResponse>(options);
            return _responseMovieList;
        }


        public async Task<ClassTmdbMovieDetailsResponse> GetMovieDetailsById(int id) {
            var options = new RestClientOptions($"https://api.themoviedb.org/3/movie/{id}?language=en-US");
            ClassTmdbMovieDetailsResponse _responseMovieDetails = await MakeTmdbRequest<ClassTmdbMovieDetailsResponse>(options);
            return _responseMovieDetails;
        }
    }
}





