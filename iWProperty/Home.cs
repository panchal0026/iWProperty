using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iWProperty
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnManageLocation_Click(object sender, EventArgs e)
        {
            Locations l = new Locations();
            l.Show();
        }

        private void btnAvailableFlats_Click(object sender, EventArgs e)
        {
            SearchFlats s = new SearchFlats();
            s.Show();
        }
    }
}
