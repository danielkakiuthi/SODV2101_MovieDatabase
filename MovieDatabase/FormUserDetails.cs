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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase {
    public partial class FormUserDetails : Form {

        private string ConnectionString { get; set; }
        private ClassUser myUserLogged;


        public FormUserDetails(string connectionString, ClassUser userLogged) {
            InitializeComponent();
            PopulateCountryComboBox();
            ConnectionString = connectionString;
            myUserLogged = userLogged;

            textBoxEmail_UserDetails.Text = myUserLogged.Email;
            textBoxPassword_UserDetails.Text = myUserLogged.Password;
            textBoxFirstName_UserDetails.Text = myUserLogged.FirstName;
            textBoxLastName_UserDetails.Text = myUserLogged.LastName;
            dateTimePickerDateBirth_UserDetails.Value = myUserLogged.DateBirth.ToDateTime(new TimeOnly(0, 0, 0));
            comboBoxCountry_UserDetails.SelectedItem = myUserLogged.Country;
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
                comboBoxCountry_UserDetails.Items.Add(item);
            }
        }


        private void buttonUpdate_UserDetails_Click(object sender, EventArgs e) {
            //Build Select Query
            int userId = myUserLogged.Id;
            string newEmail = textBoxEmail_UserDetails.Text;
            string newPassword = textBoxPassword_UserDetails.Text;
            string newFirstName = textBoxFirstName_UserDetails.Text;
            string newLastName = textBoxLastName_UserDetails.Text;
            string newDateBirth = dateTimePickerDateBirth_UserDetails.Value.ToShortDateString();
            string newCountry = comboBoxCountry_UserDetails.Text;
            Debug.WriteLine($"inputDateBirth: {newDateBirth}");

            if (newEmail == "" || newPassword == "" || newFirstName == "" || newLastName == "" || newCountry == "") {
                MessageBox.Show($"[ERROR] Please fill all required (*) fields!");
                return;
            }

            string updateQuery = "UPDATE dbo.Users ";
            updateQuery += $"SET email = '{newEmail}', ";
            updateQuery += $"password = '{newPassword}', ";
            updateQuery += $"firstName = '{newFirstName}', ";
            updateQuery += $"lastName = '{newLastName}', ";
            updateQuery += $"dateBirth = '{newDateBirth}', ";
            updateQuery += $"country = '{newCountry}' ";
            updateQuery += $"WHERE id = '{userId}'; ";

            try {
                using (SqlConnection cnn = new SqlConnection(ConnectionString)) {
                    using (SqlCommand cmd = new SqlCommand(updateQuery, cnn)) {
                        cnn.Open();
                        cmd.ExecuteNonQuery();


                        MessageBox.Show($"[User Updated] Fieldsfor {newEmail} were successfully updated!");
                        //Reload Form
                        this.Parent.Parent.Parent.Invalidate();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"[ERROR] Something went wrong!\n{ex.Message}");
            }
        }

        private void buttonCancel_UserDetails_Click(object sender, EventArgs e) {
            //Go back to Homepage
            ((TabControl)this.Parent.Parent).SelectTab("TabHomepage");        
        }
    }
}
