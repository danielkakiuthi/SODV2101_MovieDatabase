using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text.RegularExpressions;
using MovieDatabase.SqlClient;



namespace MovieDatabase {
    public partial class FormUserRegister : Form
    {
        public ClassSqlClient mySqlClient;
        ErrorProvider myErrorProvider { get; set; }


        public FormUserRegister()
        {
            InitializeComponent();
            mySqlClient = new ClassSqlClient();
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
        private void PopulateCountryComboBox()
        {
            RegionInfo country = new RegionInfo(new CultureInfo("en-US", false).LCID);
            List<string> countryNames = new List<string>();
            foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                country = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                countryNames.Add(country.EnglishName.ToString());
            }
            IEnumerable nameAdded = countryNames.OrderBy(names => names).Distinct();
            foreach (string item in nameAdded)
            {
                comboBoxCountry_UserRegister.Items.Add(item);
            }
            comboBoxCountry_UserRegister.SelectedItem = "Canada";
        }


        private void buttonRegister_Register_Click(object sender, EventArgs e)
        {

            //Build Select Query
            string inputEmail = textBoxEmail_UserRegister.Text;
            string inputPassword = textBoxPassword_UserRegister.Text;
            string inputFirstName = textBoxFirstName_UserRegister.Text;
            string inputLastName = textBoxLastName_UserRegister.Text;
            string inputDateBirth = dateTimePickerDateBirth_UserRegister.Value.ToShortDateString();
            string inputCountry = comboBoxCountry_UserRegister.Text;


            //Check for empty fields
            if (inputEmail == "")
            {
                MessageBox.Show($"[ERROR] Please fill Email field!");
                textBoxEmail_UserRegister.Focus();
                return;
            }
            else if (inputPassword == "")
            {
                MessageBox.Show($"[ERROR] Please fill Password field!");
                textBoxPassword_UserRegister.Focus();
                return;
            }
            else if (inputFirstName == "")
            {
                MessageBox.Show($"[ERROR] Please fill First Name field!");
                textBoxFirstName_UserRegister.Focus();
                return;
            }
            else if (inputLastName == "")
            {
                MessageBox.Show($"[ERROR] Please fill Last Name field!");
                textBoxLastName_UserRegister.Focus();
                return;
            }
            else if (inputCountry == "")
            {
                MessageBox.Show($"[ERROR] Please fill Country field!");
                comboBoxCountry_UserRegister.Focus();
                return;
            }

            string insertQuery = "INSERT INTO dbo.Users (email, password, firstName, lastName, dateBirth, country) ";
            insertQuery += $"VALUES ('{inputEmail}', '{inputPassword}', '{inputFirstName}', '{inputLastName}', '{inputDateBirth}', '{inputCountry}'); ";

            if(mySqlClient.InsertNewUser(insertQuery)) {
                MessageBox.Show($"[User Registered] New user {inputEmail} was successfully added!");
            }


            //Switch Forms
            this.Owner.Show();
            this.Close();
        }


        private void buttonCancel_Register_Click(object sender, EventArgs e)
        {
            //Switch Forms
            this.Owner.Show();
            this.Close();
        }

        private void textBoxEmail_UserRegister_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^([a-zA-Z]([-\.\w]*[a-zA-Z0-9])*@[a-zA-Z]*[-\w]*[a-zA-Z]\.)+[a-zA-Z]{2,10}$");

            if (regex.IsMatch(textBoxEmail_UserRegister.Text))
            {
                myErrorProvider.Clear();
            }
            else
            {
                myErrorProvider.SetError(textBoxEmail_UserRegister, "Invalid Email Address!");
                return;
            }
        }

        private void FormUserRegister_Paint(object sender, PaintEventArgs e)
        {

            Color c1 = Color.FromArgb(255, 210, 54, 0);
            Color c2 = Color.FromArgb(255, 211, 87, 0);
            Color c3 = Color.FromArgb(255, 208, 115, 0);
            Color c4 = Color.FromArgb(255, 201, 141, 0);
            Color c5 = Color.FromArgb(255, 190, 165, 0);
            Color c6 = Color.FromArgb(255, 175, 188, 0);
            Color c7 = Color.FromArgb(255, 156, 210, 0);

            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, c1, c7, 120, true);
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, (float)0.146, (float)0.317, (float)0.439, (float)0.585, (float)0.797, 1 };
            cb.Colors = new[] { c1, c2, c3, c4, c5, c6, c7 };
            br.InterpolationColors = cb;

            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }

        private void FormUserRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
