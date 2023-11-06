using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            groupBoxMenu.Location = new Point(0,0);
            groupBoxMenu.Size = new Size((int)(screenWidth*0.1), screenHeight);

            //Adjust Buttons properties
            buttonHomepage.Location = new Point(0, 50);
            buttonHomepage.Size = new Size(groupBoxMenu.Width, 30);
            buttonAccount.Location = new Point(0, 100);
            buttonAccount.Size = new Size(groupBoxMenu.Width, 30);
            buttonTestApi.Location = new Point(0, 150);
            buttonTestApi.Size = new Size(groupBoxMenu.Width, 30);
            

            //Adjust panelContent_Homepage properties
            panelContent_Homepage.Location = new Point(groupBoxMenu.Width, 0);
            panelContent_Homepage.Size = new Size(screenWidth-groupBoxMenu.Width, screenHeight);
            panelContent_Homepage.BackColor = Color.LightSteelBlue; //Just to check area of the panel
        }

        private void buttonTestAPI_Click(object sender, EventArgs e) {
            FormTitleInformation formTitleInformation = new FormTitleInformation();
            formTitleInformation.TopLevel = false;
            formTitleInformation.AutoScroll = true;


            Panel panelContent_Homepage = (Panel)((Button)sender).Parent.Parent.Controls["panelContent_Homepage"];
            
            panelContent_Homepage.Controls.Add(formTitleInformation);
            formTitleInformation.Show();
        }
    }
}
