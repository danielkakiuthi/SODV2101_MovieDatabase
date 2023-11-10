namespace MovieDatabase {
    public partial class FormMain : Form {

        private int screenWidth;
        private int screenHeight;
        private ClassController myController;
        private TabPage? tabHomepage;
        private TabPage? tabUserRegister;
        private TabPage? tabUserLogin;
        private TabPage? tabUserDetails;
        private TabPage? tabTitleSearch;
        private TabPage? tabTitleDetails;

        public FormMain() {
            //Initialize Objects
            InitializeComponent();
            myController = new ClassController();

            //Set Main Window properties
            WindowState = FormWindowState.Maximized;
            screenWidth = Screen.PrimaryScreen.Bounds.Width;
            screenHeight = Screen.PrimaryScreen.Bounds.Height;

            //Adjust Menu properties
            groupBoxMenu_Main.Location = new Point(0, 0);
            groupBoxMenu_Main.Size = new Size((int)(screenWidth * 0.1), screenHeight);

            //Adjust Menu Buttons properties
            buttonHomepage_Main.Location = new Point(0, 50);
            buttonHomepage_Main.Size = new Size(groupBoxMenu_Main.Width-10, 30);
            buttonUserDetails_Main.Location = new Point(0, 100);
            buttonUserDetails_Main.Size = new Size(groupBoxMenu_Main.Width-10, 30);
            buttonSearch_Main.Location = new Point(0, 150);
            buttonSearch_Main.Size = new Size(groupBoxMenu_Main.Width-10, 30);
            buttonUserLogin_Main.Location = new Point(0, screenHeight-100);
            buttonUserLogin_Main.Size = new Size(groupBoxMenu_Main.Width-10, 30);


            //Initialize Homepage Tab
            FormHomepage formHomepage = new FormHomepage();
            formHomepage.TopLevel = false;
            formHomepage.AutoScroll = true;
            formHomepage.Dock = DockStyle.Fill;
            formHomepage.FormBorderStyle = FormBorderStyle.None;
            formHomepage.Show();
            tabHomepage = new TabPage("Tab Homepage");
            tabHomepage.Controls.Add(formHomepage);
            tabControlContent_Main.TabPages.Add(tabHomepage);
            tabControlContent_Main.SelectTab(tabHomepage);

            //Initialize TitleSearch Tab
            FormTitleSearch formTitleInformation = new FormTitleSearch();
            formTitleInformation.TopLevel = false;
            formTitleInformation.AutoScroll = true;
            formTitleInformation.Dock = DockStyle.Fill;
            formTitleInformation.FormBorderStyle = FormBorderStyle.None;
            formTitleInformation.Show();
            tabTitleSearch = new TabPage("Tab Title Search");
            tabTitleSearch.Controls.Add(formTitleInformation);
            tabControlContent_Main.TabPages.Add(tabTitleSearch);
            tabControlContent_Main.SelectTab(tabTitleSearch);

            //Initialize UserDetails Tab
            FormUserDetails formUserDetails = new FormUserDetails();
            formUserDetails.TopLevel = false;
            formUserDetails.AutoScroll = true;
            formUserDetails.Dock = DockStyle.Fill;
            formUserDetails.FormBorderStyle = FormBorderStyle.None;
            formUserDetails.Show();
            tabUserDetails = new TabPage("Tab User Details");
            tabUserDetails.Controls.Add(formUserDetails);
            tabControlContent_Main.TabPages.Add(tabUserDetails);
            tabControlContent_Main.SelectTab(tabUserDetails);

            //Initialize UserLogin Tab
            FormUserLogin formUserLogin = new FormUserLogin();
            formUserLogin.TopLevel = false;
            formUserLogin.AutoScroll = true;
            formUserLogin.Dock = DockStyle.Fill;
            formUserLogin.FormBorderStyle = FormBorderStyle.None;
            formUserLogin.Show();
            tabUserLogin = new TabPage("Tab User Login");
            tabUserLogin.Controls.Add(formUserLogin);
            tabControlContent_Main.TabPages.Add(tabUserLogin);
            tabControlContent_Main.SelectTab(tabUserLogin);

            //Adjust Tab Control properties
            tabControlContent_Main.Location = new Point(groupBoxMenu_Main.Width, 0);
            tabControlContent_Main.Size = new Size(screenWidth - groupBoxMenu_Main.Width, screenHeight);
            tabControlContent_Main.BackColor = Color.LightSteelBlue; //Just to check area of the panel
            tabControlContent_Main.SelectTab(tabHomepage);          //Start on Homepage tab

            //Hide Tab Headers
            {
                tabControlContent_Main.Appearance = TabAppearance.FlatButtons;
                tabControlContent_Main.ItemSize = new Size(0, 1);
                tabControlContent_Main.SizeMode = TabSizeMode.Fixed;
            }


        }

        private void buttonHomepage_Main_Click(object sender, EventArgs e) {

            tabControlContent_Main.SelectTab(tabHomepage);
        }


        private void buttonTitleSearch_Main_Click(object sender, EventArgs e) {

            tabControlContent_Main.SelectTab(tabTitleSearch);
        }

        private void buttonUserDetails_Main_Click(object sender, EventArgs e) {

            tabControlContent_Main.SelectTab(tabUserDetails);
        }

        private void buttonUserLogin_Click(object sender, EventArgs e) {
            tabControlContent_Main.SelectTab(tabUserLogin);
        }
    }
}