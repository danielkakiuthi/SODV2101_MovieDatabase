
using MovieDatabase.SqlClient;



namespace MovieDatabase {

    public partial class FormUserLogin : Form {


        public ClassSqlClient mySqlClient;
        public ClassUser? MyUserLogged { get; set; }
        private FormUserRegister? MyFormUserRegister { get; set; }
        private FormFrame? MyFormFrame { get; set; }


        public FormUserLogin() {

            mySqlClient = new ClassSqlClient();

            InitializeComponent();
            MyUserLogged = null;
            MyFormUserRegister = null;
            MyFormFrame = null;

            this.CenterToScreen();

            //Fill Placeholders text
            textBoxEmail_UserLogin.PlaceholderText = "email@email.com";
            textBoxPassword_UserLogin.PlaceholderText = "**********";
        }



        private void buttonLogin_UserLogin_Click(object sender, EventArgs e)
        {

            //Build Select Query
            string selectQuery = "SELECT id, email, password, firstName, lastName, dateBirth, country ";
            selectQuery += "FROM dbo.Users ";
            selectQuery += $"WHERE email = '{textBoxEmail_UserLogin.Text}' AND password = '{textBoxPassword_UserLogin.Text}'; ";

            MyUserLogged = mySqlClient.AuthenticateLogin(selectQuery);

            if(MyUserLogged != null ) {
                //Switch windows
                MyFormFrame = new FormFrame(MyUserLogged);
                MyFormFrame.Owner = this;
                this.Hide();
                MyFormFrame.Show();
            }

            //Reset textBoxes values
            textBoxEmail_UserLogin.Text = string.Empty;
            textBoxPassword_UserLogin.Text = string.Empty;
        }

        private void linkLabelRegister_UserLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Switch Forms
            MyFormUserRegister = new FormUserRegister();
            MyFormUserRegister.Owner = this;
            this.Hide();
            MyFormUserRegister.Show();
        }

        private void FormUserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
