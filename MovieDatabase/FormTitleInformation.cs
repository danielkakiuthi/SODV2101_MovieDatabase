using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace MovieDatabase {
    public partial class FormTitleInformation : Form {

        public ClassTitle myTitle;

        public FormTitleInformation() {
            InitializeComponent();
        }

        
        private async void FormTitleInformation_Load(object sender, EventArgs e) {
            var response = await GetTitle();

            textBoxResult.Text = response;
        }


        public async Task<string> GetTitle() {
            var config = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            var omdb_ApiKey = config["OMDB_APIKEY"];

            Console.WriteLine(omdb_ApiKey);
            try {
                using(HttpClient myClient = new HttpClient()) {

                    myClient.BaseAddress = new Uri("http://www.omdbapi.com");

                    using(HttpResponseMessage res = await myClient.GetAsync($"/?t=avengers&apikey={omdb_ApiKey}")) {

                        using (HttpContent content = res.Content) {

                            string data = await content.ReadAsStringAsync();
                            
                            if (data != null) {
                                labelError.Visible = false;
                                return data;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                string message = $"[API Error]: {ex.Message}" + Environment.NewLine;
                labelError.Text = message;
            }
            return string.Empty;
        }

    }
}
