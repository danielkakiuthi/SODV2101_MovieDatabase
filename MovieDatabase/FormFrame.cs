using System.Drawing.Drawing2D;

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
            int _menuWidth = (int)(screenWidth * 0.1);
            int _menuHeight = (int)(screenHeight);
            groupBoxMenu_Frame.Location = new Point(0, 0);
            groupBoxMenu_Frame.Size = new Size(_menuWidth, _menuHeight);

            //Adjust Logo
            pictureBoxLogo.Image = Image.FromFile("../../../Resources/MovieDatabase_HighResLogo_White_Cropped.png");
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            //Adjust Menu Buttons properties
            buttonHomepage_Frame.Location = new Point(0, 100);
            buttonHomepage_Frame.Size = new Size(groupBoxMenu_Frame.Width - 10, 30);
            buttonUserDetails_Frame.Location = new Point(0, 150);
            buttonUserDetails_Frame.Size = new Size(groupBoxMenu_Frame.Width - 10, 30);
            buttonTitleSearch_Frame.Location = new Point(0, 200);
            buttonTitleSearch_Frame.Size = new Size(groupBoxMenu_Frame.Width - 10, 30);
            buttonFavoriteDetails_Frame.Location = new Point(0, 250);
            buttonFavoriteDetails_Frame.Size = new Size(groupBoxMenu_Frame.Width - 10, 30);
            buttonLogout_Frame.Location = new Point(0, screenHeight - 100);
            buttonLogout_Frame.Size = new Size(groupBoxMenu_Frame.Width - 10, 30);


            //Initialize Homepage Tab
            FormHomepage formHomepage = new FormHomepage(screenWidth - groupBoxMenu_Frame.Width) {
                TopLevel = false,
                AutoScroll = true,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            formHomepage.Show();
            tabHomepage = new TabPage() {
                Text = "Tab Homepage",
                Name = "TabHomepage",
                Controls = { formHomepage }
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
                Controls = { formUserDetails }
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
                Controls = { formTitleInformation }
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
                Controls = { formTitleDetails }
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
            buttonHomepage_Frame.BackColor = System.Drawing.Color.Green;
            buttonUserDetails_Frame.BackColor = System.Drawing.Color.Blue;
            buttonTitleSearch_Frame.BackColor = System.Drawing.Color.Blue;
            buttonFavoriteDetails_Frame.BackColor = System.Drawing.Color.Blue;
        }


        private void buttonUserDetails_Frame_Click(object sender, EventArgs e) {
            tabControlContent_Frame.SelectTab(tabUserDetails);
            buttonUserDetails_Frame.BackColor = System.Drawing.Color.Green;
            buttonHomepage_Frame.BackColor = System.Drawing.Color.Blue;
            buttonTitleSearch_Frame.BackColor = System.Drawing.Color.Blue;
            buttonFavoriteDetails_Frame.BackColor = System.Drawing.Color.Blue;
        }


        private void buttonTitleSearch_Frame_Click(object sender, EventArgs e) {
            tabControlContent_Frame.SelectTab(tabTitleSearch);
            buttonTitleSearch_Frame.BackColor = System.Drawing.Color.Green;
            buttonHomepage_Frame.BackColor = System.Drawing.Color.Blue;
            buttonUserDetails_Frame.BackColor = System.Drawing.Color.Blue;
            buttonFavoriteDetails_Frame.BackColor = System.Drawing.Color.Blue;
        }
        private void buttonFavoriteDetails_Frame_Click(object sender, EventArgs e) {
            tabControlContent_Frame.SelectTab(tabTitleDetails);
            buttonFavoriteDetails_Frame.BackColor = System.Drawing.Color.Green;
            buttonHomepage_Frame.BackColor = System.Drawing.Color.Blue;
            buttonUserDetails_Frame.BackColor = System.Drawing.Color.Blue;
            buttonTitleSearch_Frame.BackColor = System.Drawing.Color.Blue;
        }

        private void buttonLogout_Frame_Click(object sender, EventArgs e) {
            this.Owner.Show();
            this.Close();
        }

        private void groupBoxMenu_Frame_Paint(object sender, PaintEventArgs e) {

            Color c1 = Color.FromArgb(255, 174, 0, 255);
            Color c2 = Color.FromArgb(255, 163, 5, 243);
            Color c3 = Color.FromArgb(255, 153, 8, 231);
            Color c4 = Color.FromArgb(255, 143, 11, 219);
            Color c5 = Color.FromArgb(255, 133, 13, 207);
            Color c6 = Color.FromArgb(255, 123, 14, 195);
            Color c7 = Color.FromArgb(255, 114, 14, 183);

            // Changed: c1 / c7 as start colors, and at 90 degrees.  Removed later transform.
            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, c1, c7, 270, true);
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, (float)0.146, (float)0.317, (float)0.439, (float)0.585, (float)0.797, 1 };
            cb.Colors = new[] { c1, c2, c3, c4, c5, c6, c7 };
            br.InterpolationColors = cb;

            // removed rotate call

            // paint
            e.Graphics.FillRectangle(br, this.ClientRectangle);

        }
    }
}