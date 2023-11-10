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
    public partial class FormUserRegister : Form {

        public string emailNewUser;
        public string passwordNewUser;
        public string nameNewUser;
        public string ageNewUser;
        public string countryNewUser;


        public FormUserRegister() {
            InitializeComponent();
        }
    }
}
