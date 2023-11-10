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
    public partial class FormTitleDetails : Form {

        public string KeywordQuery { get; set; }
        public string GenreQuery { get; set; }
        public int YearQuery { get; set; }
        public string RatingQuery { get; set; }


        public FormTitleDetails() {
            InitializeComponent();
        }
    }
}
