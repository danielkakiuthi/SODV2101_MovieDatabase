using Microsoft.Extensions.Configuration;
using MovieDatabase.OmdbApi;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.SqlClient {
    public class ClassSqlClient {

        public string ConnectionString { get; set; }


        public ClassSqlClient() {
            string path_RootFolder = $"{Directory.GetParent(System.IO.Directory.GetCurrentDirectory())?.Parent?.Parent}";
            //Debug.WriteLine($"path_RootFolder: {path_RootFolder}");       //DEBUG
            ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; ";
            ConnectionString += $"AttachDbFilename={path_RootFolder}\\LocalDatabase.mdf; ";
            ConnectionString += "Integrated Security=True; ";
        }


        public bool InsertNewUser(string insertQuery) {
            try {
                using (SqlConnection cnn = new SqlConnection(ConnectionString)) {
                    using (SqlCommand cmd = new SqlCommand(insertQuery, cnn)) {
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex) {
                Debug.WriteLine($"[ERROR] Something went wrong!\n{ex.Message}");
                return false;
            }
        }


        public void UpdateUser(string updateQuery) {
            try {
                using (SqlConnection cnn = new SqlConnection(ConnectionString)) {
                    using (SqlCommand cmd = new SqlCommand(updateQuery, cnn)) {
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) {
                Debug.WriteLine($"[ERROR] Something went wrong!\n{ex.Message}");
            }
        }


        public ClassUser AuthenticateLogin(string selectQuery) {
            try {
                using (SqlConnection cnn = new SqlConnection(ConnectionString)) {
                    using (SqlCommand cmd = new SqlCommand(selectQuery, cnn)) {
                        cnn.Open();
                        using (SqlDataReader myReader = cmd.ExecuteReader()) {
                            if (myReader.Read()) {

                                //Create MyUserLogged Object
                                int inputId = (int)myReader[0];
                                string inputEmail = (string)myReader[1];
                                string inputPassword = (string)myReader[2];
                                string inputFirstName = (string)myReader[3];
                                string inputLastName = (string)myReader[4];
                                DateOnly inputDateBirth = DateOnly.ParseExact(myReader[5].ToString(), "yyyy-MM-dd hh:mm:ss tt");
                                string inputCountry = (string)myReader[6];
                                ClassUser MyUserLogged = new ClassUser(inputId, inputEmail, inputPassword, inputFirstName, inputLastName, inputDateBirth, inputCountry);
                                Debug.WriteLine($"[Login Successful] Logged in as: {MyUserLogged.FirstName} {MyUserLogged.LastName}");

                                return MyUserLogged;
                            }
                            else {
                                MessageBox.Show("[Incorrect Credentials] Try Again!");
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                Debug.WriteLine($"[ERROR] Something went wrong!\n{ex.Message}");
                return null;
            }
        }


        public bool AddMoviesToFavorites(string insertQuery) {

            try {
                using (SqlConnection cnn = new SqlConnection(ConnectionString)) {
                    using (SqlCommand cmd = new SqlCommand(insertQuery, cnn)) {
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
                return true;
            }
            catch (Exception ex) {
                Debug.WriteLine($"[ERROR] Something went wrong!\n{ex.Message}");
                return false;
            }
        }


        public async Task<List<string>> GetFavoriteListFromDatabase(string selectQuery) {
            List<string> favorites = new List<string>();

            try {
                using (SqlConnection cnn = new SqlConnection(ConnectionString)) {
                    await cnn.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(selectQuery, cnn)) {
                        //cmd.Parameters.AddWithValue("@userId", userId);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync()) {
                            while (await reader.ReadAsync()) {
                                string imdbId = reader["imdbID"].ToString();
                                favorites.Add(imdbId);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                Debug.WriteLine($"Error getting favorites list from database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return favorites;
        }


        public bool RemoveMovieFromFavorites(string deleteQuery) {
            try {
                using (SqlConnection cnn = new SqlConnection(ConnectionString)) {
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, cnn)) {
                        cnn.Open();

                        // Use parâmetros para evitar SQL Injection e tratar corretamente valores de texto
                        //cmd.Parameters.AddWithValue("@userID", userID);
                        //cmd.Parameters.AddWithValue("@imdbID", imdbID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex) {
                Debug.WriteLine($"[ERROR] Something went wrong!\n{ex.Message}");
                return false;
            }
        }
    }
}
