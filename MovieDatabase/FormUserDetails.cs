using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            int _formWidth = this.Width;
            int _formHeight = this.Height;
            int _groupBoxUserDetailsWidth = groupBox_UserDetails.Width;
            int _groupBoxUserDetailsHeight = groupBox_UserDetails.Height;

            //groupBox_UserDetails.Location = new Point(0,0);
            groupBox_UserDetails.Location = new Point((_formWidth - _groupBoxUserDetailsWidth) / 2, (_formHeight - _groupBoxUserDetailsHeight) / 2);

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

        private void FormUserDetails_Paint(object sender, PaintEventArgs e) {
            Color c1 = Color.FromArgb(255, 0, 3, 88);
            Color c2 = Color.FromArgb(255, 0, 18, 94);
            Color c3 = Color.FromArgb(255, 0, 29, 99);
            Color c4 = Color.FromArgb(255, 0, 39, 103);
            Color c5 = Color.FromArgb(255, 0, 48, 105);
            Color c6 = Color.FromArgb(255, 0, 57, 106);
            Color c7 = Color.FromArgb(255, 10, 65, 107);

            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, c1, c7, 90, true);
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, (float)0.146, (float)0.317, (float)0.439, (float)0.585, (float)0.797, 1 };
            cb.Colors = new[] { c1, c2, c3, c4, c5, c6, c7 };
            br.InterpolationColors = cb;

            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }

        private void FormUserDetails_Load(object sender, EventArgs e) {

        }
    }
}
