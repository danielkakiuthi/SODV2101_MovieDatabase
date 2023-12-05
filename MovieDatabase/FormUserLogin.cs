using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase {

    public partial class FormUserLogin : Form {

        private string ConnectionString { get; set; }
        public ClassUser? MyUserLogged { get; set; }
        private FormUserRegister? MyFormUserRegister { get; set; }
        private FormFrame? MyFormFrame { get; set; }


        public FormUserLogin() {
            InitializeComponent();
            MyUserLogged = null;
            MyFormUserRegister = null;
            MyFormFrame = null;

            string path_RootFolder = $"{Directory.GetParent(System.IO.Directory.GetCurrentDirectory())?.Parent?.Parent}";
            //Debug.WriteLine($"path_RootFolder: {path_RootFolder}");       //DEBUG
            ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; ";
            ConnectionString += $"AttachDbFilename={path_RootFolder}\\LocalDatabase.mdf; ";
            ConnectionString += "Integrated Security=True; ";

            this.CenterToScreen();
        }



        private void buttonLogin_UserLogin_Click(object sender, EventArgs e) {

            //Build Select Query
            string selectQuery = "SELECT id, email, password, firstName, lastName, dateBirth, country ";
            selectQuery += "FROM dbo.Users ";
            selectQuery += $"WHERE email = '{textBoxEmail_UserLogin.Text}' AND password = '{textBoxPassword_UserLogin.Text}'; ";

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
                                MyUserLogged = new ClassUser(inputId, inputEmail, inputPassword, inputFirstName, inputLastName, inputDateBirth, inputCountry);
                                Debug.WriteLine($"[Login Successful] Logged in as: {MyUserLogged.FirstName} {MyUserLogged.LastName}");

                                //Switch windows
                                MyFormFrame = new FormFrame(ConnectionString, MyUserLogged);
                                MyFormFrame.Owner = this;
                                this.Hide();
                                MyFormFrame.Show();
                            }
                            else {
                                MessageBox.Show("[Incorrect Credentials] Try Again!");
                            }

                            textBoxEmail_UserLogin.Text = string.Empty;
                            textBoxPassword_UserLogin.Text = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"[ERROR] Something went wrong!\n{ex.Message}");
            }
        }

        private void linkLabelRegister_UserLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //Switch Forms
            MyFormUserRegister = new FormUserRegister(ConnectionString);
            MyFormUserRegister.Owner = this;
            this.Hide();
            MyFormUserRegister.Show();
        }
    }
}
