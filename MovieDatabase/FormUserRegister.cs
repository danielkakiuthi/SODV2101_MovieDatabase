using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase {
    public partial class FormUserRegister : Form {

        public string ConnectionString { get; set; }
        ErrorProvider myErrorProvider { get; set; }


        public FormUserRegister(string connectionString) {
            InitializeComponent();
            ConnectionString = connectionString;
            myErrorProvider = new ErrorProvider();

            this.CenterToScreen();
            PopulateCountryComboBox();

            //Fill Placeholders text
            textBoxEmail_UserRegister.PlaceholderText = "email@email.com";
            textBoxPassword_UserRegister.PlaceholderText = "**********";
            textBoxFirstName_UserRegister.PlaceholderText = "John";
            textBoxLastName_UserRegister.PlaceholderText = "Doe";
            comboBoxCountry_UserRegister.SelectedIndex = 22;

        }


        //Populate comboBoxCountry_Register
        private void PopulateCountryComboBox() {
            RegionInfo country = new RegionInfo(new CultureInfo("en-US", false).LCID);
            List<string> countryNames = new List<string>();
            foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures)) {
                country = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                countryNames.Add(country.EnglishName.ToString());
            }
            IEnumerable nameAdded = countryNames.OrderBy(names => names).Distinct();
            foreach (string item in nameAdded) {
                comboBoxCountry_UserRegister.Items.Add(item);
            }
            comboBoxCountry_UserRegister.SelectedItem = "Canada";
        }


        private void buttonRegister_Register_Click(object sender, EventArgs e) {

            //Build Select Query
            string inputEmail = textBoxEmail_UserRegister.Text;
            string inputPassword = textBoxPassword_UserRegister.Text;
            string inputFirstName = textBoxFirstName_UserRegister.Text;
            string inputLastName = textBoxLastName_UserRegister.Text;
            string inputDateBirth = dateTimePickerDateBirth_UserRegister.Value.ToShortDateString();
            string inputCountry = comboBoxCountry_UserRegister.Text;


            //Check for empty fields
            if (inputEmail == "") {
                MessageBox.Show($"[ERROR] Please fill Email field!");
                textBoxEmail_UserRegister.Focus();
                return;
            }
            else if (inputPassword == "") {
                MessageBox.Show($"[ERROR] Please fill Password field!");
                textBoxPassword_UserRegister.Focus();
                return;
            }
            else if (inputFirstName == "") {
                MessageBox.Show($"[ERROR] Please fill First Name field!");
                textBoxFirstName_UserRegister.Focus();
                return;
            }
            else if (inputLastName == "") {
                MessageBox.Show($"[ERROR] Please fill Last Name field!");
                textBoxLastName_UserRegister.Focus();
                return;
            }
            else if (inputCountry == "") {
                MessageBox.Show($"[ERROR] Please fill Country field!");
                comboBoxCountry_UserRegister.Focus( );
                return;
            }



            string insertQuery = "INSERT INTO dbo.Users (email, password, firstName, lastName, dateBirth, country) ";
            insertQuery += $"VALUES ('{inputEmail}', '{inputPassword}', '{inputFirstName}', '{inputLastName}', '{inputDateBirth}', '{inputCountry}'); ";

            try {
                using (SqlConnection cnn = new SqlConnection(ConnectionString)) {
                    using (SqlCommand cmd = new SqlCommand(insertQuery, cnn)) {
                        cnn.Open();
                        cmd.ExecuteNonQuery();

                        //Switch Forms
                        this.Owner.Show();
                        this.Close();
                        MessageBox.Show($"[User Registered] New user {inputEmail} was successfully added!");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"[ERROR] Something went wrong!\n{ex.Message}");
            }
        }


        private void buttonCancel_Register_Click(object sender, EventArgs e) {
            //Switch Forms
            this.Owner.Show();
            this.Close();
        }

        private void textBoxEmail_UserRegister_Validating(object sender, CancelEventArgs e) {
            Regex regex = new Regex(@"^([a-zA-Z]([-\.\w]*[a-zA-Z0-9])*@[a-zA-Z]*[-\w]*[a-zA-Z]\.)+[a-zA-Z]{2,10}$");

            if (regex.IsMatch(textBoxEmail_UserRegister.Text)) {
                myErrorProvider.Clear();
            }
            else {
                myErrorProvider.SetError(textBoxEmail_UserRegister, "Invalid Email Address!");
                return;
            }
        }
    }
}
