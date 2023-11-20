namespace MovieDatabase {
    public partial class FormFrame : Form {

        private int screenWidth;
        private int screenHeight;
        private string ConnectionString;
        private ClassUser myUserLogged;
        private ClassController myController;
        private TabPage? tabHomepage;
        private TabPage? tabUserRegister;
        private TabPage? tabUserLogin;
        private TabPage? tabUserDetails;
        private TabPage? tabTitleSearch;
        private TabPage? tabTitleDetails;

        public FormFrame(string connectionString, ClassUser userLogged) {
            //Initialize Objects
            InitializeComponent();
            ConnectionString = connectionString;
            myUserLogged = userLogged;
            myController = new ClassController();

            //Set Frame Window properties
            WindowState = FormWindowState.Maximized;
            screenWidth = Screen.PrimaryScreen.Bounds.Width;
            screenHeight = Screen.PrimaryScreen.Bounds.Height;

            //Adjust Menu properties
            groupBoxMenu_Frame.Location = new Point(0, 0);
            groupBoxMenu_Frame.Size = new Size((int)(screenWidth * 0.1), screenHeight);

            //Adjust Menu Buttons properties
            buttonHomepage_Frame.Location = new Point(0, 100);
            buttonHomepage_Frame.Size = new Size(groupBoxMenu_Frame.Width - 10, 30);
            buttonUserDetails_Frame.Location = new Point(0, 150);
            buttonUserDetails_Frame.Size = new Size(groupBoxMenu_Frame.Width - 10, 30);
            buttonSearch_Frame.Location = new Point(0, 200);
            buttonSearch_Frame.Size = new Size(groupBoxMenu_Frame.Width - 10, 30);
            buttonLogout_Frame.Location = new Point(0, screenHeight - 100);
            buttonLogout_Frame.Size = new Size(groupBoxMenu_Frame.Width - 10, 30);


            //Initialize Homepage Tab
            FormHomepage formHomepage = new FormHomepage();
            formHomepage.TopLevel = false;
            formHomepage.AutoScroll = true;
            formHomepage.Dock = DockStyle.Fill;
            formHomepage.FormBorderStyle = FormBorderStyle.None;
            formHomepage.Show();
            tabHomepage = new TabPage("Tab Homepage");
            tabHomepage.Controls.Add(formHomepage);
            tabControlContent_Frame.TabPages.Add(tabHomepage);
            tabControlContent_Frame.SelectTab(tabHomepage);

            //Initialize TitleSearch Tab
            FormTitleSearch formTitleInformation = new FormTitleSearch();
            formTitleInformation.TopLevel = false;
            formTitleInformation.AutoScroll = true;
            formTitleInformation.Dock = DockStyle.Fill;
            formTitleInformation.FormBorderStyle = FormBorderStyle.None;
            formTitleInformation.Show();
            tabTitleSearch = new TabPage("Tab Title Search");
            tabTitleSearch.Controls.Add(formTitleInformation);
            tabControlContent_Frame.TabPages.Add(tabTitleSearch);
            tabControlContent_Frame.SelectTab(tabTitleSearch);

            //Initialize UserDetails Tab
            FormUserDetails formUserDetails = new FormUserDetails();
            formUserDetails.TopLevel = false;
            formUserDetails.AutoScroll = true;
            formUserDetails.Dock = DockStyle.Fill;
            formUserDetails.FormBorderStyle = FormBorderStyle.None;
            formUserDetails.Show();
            tabUserDetails = new TabPage("Tab User Details");
            tabUserDetails.Controls.Add(formUserDetails);
            tabControlContent_Frame.TabPages.Add(tabUserDetails);
            tabControlContent_Frame.SelectTab(tabUserDetails);

            //Initialize UserLogin Tab
            FormUserLogin formUserLogin = new FormUserLogin();
            formUserLogin.TopLevel = false;
            formUserLogin.AutoScroll = true;
            formUserLogin.Dock = DockStyle.Fill;
            formUserLogin.FormBorderStyle = FormBorderStyle.None;
            formUserLogin.Show();
            tabUserLogin = new TabPage("Tab User Login");
            tabUserLogin.Controls.Add(formUserLogin);
            tabControlContent_Frame.TabPages.Add(tabUserLogin);
            tabControlContent_Frame.SelectTab(tabUserLogin);

            //Adjust Tab Control properties
            tabControlContent_Frame.Location = new Point(groupBoxMenu_Frame.Width, 0);
            tabControlContent_Frame.Size = new Size(screenWidth - groupBoxMenu_Frame.Width, screenHeight);
            tabControlContent_Frame.BackColor = Color.LightSteelBlue; //Just to check area of the panel
            tabControlContent_Frame.SelectTab(tabHomepage);          //Start on Homepage tab

            //Hide Tab Headers
            {
                tabControlContent_Frame.Appearance = TabAppearance.FlatButtons;
                tabControlContent_Frame.ItemSize = new Size(0, 1);
                tabControlContent_Frame.SizeMode = TabSizeMode.Fixed;
            }

            //Display logged User firstName
            labelHeader_Frame.Text = $"Hello, {myUserLogged.FirstName}!";

        }

        private void buttonHomepage_Frame_Click(object sender, EventArgs e) {

            tabControlContent_Frame.SelectTab(tabHomepage);
        }


        private void buttonTitleSearch_Frame_Click(object sender, EventArgs e) {

            tabControlContent_Frame.SelectTab(tabTitleSearch);
        }

        private void buttonUserDetails_Frame_Click(object sender, EventArgs e) {

            tabControlContent_Frame.SelectTab(tabUserDetails);
        }

        private void buttonLogout_Frame_Click(object sender, EventArgs e) {
            this.Owner.Show();
            this.Close();
        }

    }
}