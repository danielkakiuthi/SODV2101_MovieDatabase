namespace MovieDatabase {
    public partial class FormHomepage : Form {

        public int screenWidth;
        public int screenHeight;
        public ClassController myController;


        public FormHomepage() {
            InitializeComponent();
            myController = new ClassController();

            WindowState = FormWindowState.Maximized;

            screenWidth = Screen.PrimaryScreen.Bounds.Width;
            screenHeight = Screen.PrimaryScreen.Bounds.Height;


            //Adjust Menu properties
            groupBoxMenu.Location = new Point(0, 0);
            groupBoxMenu.Size = new Size((int)(screenWidth * 0.1), screenHeight);

            //Adjust Buttons properties
            buttonHomepage_Menu.Location = new Point(0, 50);
            buttonHomepage_Menu.Size = new Size(groupBoxMenu.Width, 30);
            buttonAccount_Menu.Location = new Point(0, 100);
            buttonAccount_Menu.Size = new Size(groupBoxMenu.Width, 30);
            buttonSearch_Menu.Location = new Point(0, 150);
            buttonSearch_Menu.Size = new Size(groupBoxMenu.Width, 30);


            //Adjust panelContent_Homepage properties
            panelContent_Homepage.Location = new Point(groupBoxMenu.Width, 0);
            panelContent_Homepage.Size = new Size(screenWidth - groupBoxMenu.Width, screenHeight);
            panelContent_Homepage.BackColor = Color.LightSteelBlue; //Just to check area of the panel
        }


        private void buttonSearch_Menu_Click(object sender, EventArgs e) {
            FormTitleInformation formTitleInformation = new FormTitleInformation();
            formTitleInformation.TopLevel = false;
            formTitleInformation.AutoScroll = true;
            formTitleInformation.Dock = DockStyle.Fill;
            formTitleInformation.FormBorderStyle = FormBorderStyle.None;


            Panel panelContent_Homepage = (Panel)((Button)sender).Parent.Parent.Controls["panelContent_Homepage"];

            panelContent_Homepage.Controls.Add(formTitleInformation);
            formTitleInformation.Show();
        }
    }
}