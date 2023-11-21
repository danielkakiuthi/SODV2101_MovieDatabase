namespace MovieDatabase {
    public partial class FormFrame : Form {

        private int screenWidth;
        private int screenHeight;
        private string ConnectionString;
        private ClassUser myUserLogged;
        private ClassController myController;
        private TabPage? tabHomepage;
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
            buttonTitleSearch_Frame.Location = new Point(0, 200);
            buttonTitleSearch_Frame.Size = new Size(groupBoxMenu_Frame.Width - 10, 30);
            buttonTitleDetails_Frame.Location = new Point(0, 250);
            buttonTitleDetails_Frame.Size = new Size(groupBoxMenu_Frame.Width - 10, 30);
            buttonLogout_Frame.Location = new Point(0, screenHeight - 100);
            buttonLogout_Frame.Size = new Size(groupBoxMenu_Frame.Width - 10, 30);


            //Initialize Homepage Tab
            FormHomepage formHomepage = new FormHomepage() {
                TopLevel = false,
                AutoScroll = true,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            formHomepage.Show();
            tabHomepage = new TabPage() {
                Text = "Tab Homepage",
                Name = "TabHomepage",
                Controls = {formHomepage}
            };
            tabControlContent_Frame.TabPages.Add(tabHomepage);

            //Initialize UserDetails Tab
            FormUserDetails formUserDetails = new FormUserDetails(ConnectionString, myUserLogged) {
                TopLevel = false,
                AutoScroll = true,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            formUserDetails.Show();
            tabUserDetails = new TabPage() {
                Text = "Tab User Details",
                Name = "TabUserDetails",
                Controls = {formUserDetails}
            };
            tabControlContent_Frame.TabPages.Add(tabUserDetails);

            //Initialize TitleSearch Tab
            FormTitleSearch formTitleInformation = new FormTitleSearch() {
                TopLevel = false,
                AutoScroll = true,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            formTitleInformation.Show();
            tabTitleSearch = new TabPage() {
                Text = "Tab Title Search",
                Name = "TabTitleSearch",
                Controls = {formTitleInformation}
            };
            tabControlContent_Frame.TabPages.Add(tabTitleSearch);

            //Initialize TitleDetails Tab
            FormTitleDetails formTitleDetails = new FormTitleDetails() {
                TopLevel = false,
                AutoScroll = true,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            formTitleDetails.Show();
            tabTitleDetails = new TabPage() {
                Text = "Tab Title Details",
                Name = "TabTitleDetails",
                Controls = {formTitleDetails}
            };
            tabControlContent_Frame.TabPages.Add(tabTitleDetails);

            //Adjust Tab Control properties
            tabControlContent_Frame.Location = new Point(groupBoxMenu_Frame.Width, 0);
            tabControlContent_Frame.Size = new Size(screenWidth - groupBoxMenu_Frame.Width, screenHeight);
            tabControlContent_Frame.BackColor = Color.Red;          //Just to check area of the panel
            tabControlContent_Frame.SelectTab(tabHomepage);         //Start on Homepage tab

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


        private void buttonUserDetails_Frame_Click(object sender, EventArgs e) {
            tabControlContent_Frame.SelectTab(tabUserDetails);
        }


        private void buttonTitleSearch_Frame_Click(object sender, EventArgs e) {
            tabControlContent_Frame.SelectTab(tabTitleSearch);
        }

        private void buttonTitleDetails_Frame_Click(object sender, EventArgs e) {
            tabControlContent_Frame.SelectTab(tabTitleDetails);
        }


        private void buttonLogout_Frame_Click(object sender, EventArgs e) {
            this.Owner.Show();
            this.Close();
        }

    }
}