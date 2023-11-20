using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase {
    public partial class FormUserRegister : Form {

        public string ConnectionString { get; set; }


        public FormUserRegister(string connectionString) {
            InitializeComponent();
            ConnectionString = connectionString;

            this.CenterToScreen();
        }

        private void buttonRegister_Register_Click(object sender, EventArgs e) {
            //Build Select Query
            string inputEmail = textBoxEmail_Register.Text;
            string inputPassword = textBoxPassword_Register.Text;
            string inputFirstName = textBoxFirstName_Register.Text;
            string inputLastName = textBoxLastName_Register.Text;
            string inputDateBirth = textBoxDateBirth_Register.Text;
            string inputCountry = textBoxCountry_Register.Text;


            if(inputEmail=="" || inputPassword=="" || inputFirstName=="" || inputLastName=="" || inputDateBirth=="" || inputCountry=="") {
                MessageBox.Show($"[ERROR] Please fill all required (*) fields!");
                return;
            }

            string insertQuery = "INSERT INTO dbo.Users (email, password, firstName, lastName, dateBirth, country) ";
            insertQuery += $"VALUES ('{inputEmail}', '{inputPassword}', '{inputFirstName}', '{inputLastName}', {inputDateBirth}, '{inputCountry}'); ";

            try {
                using (SqlConnection cnn = new SqlConnection(ConnectionString)) {
                    using (SqlCommand cmd = new SqlCommand(insertQuery, cnn)) {
                        cnn.Open();
                        cmd.ExecuteNonQuery();

                        //Switch Forms
                        this.Close();
                        this.Owner.Show();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"[ERROR] Something went wrong!\n{ex.Message}");
            }
        }


        private void buttonCancel_Register_Click(object sender, EventArgs e) {
            //Switch Forms
            this.Hide();
            this.Owner.Show();
        }

    }
}
