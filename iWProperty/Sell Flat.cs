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
    public partial class Sell_Flat : Form
    {

        public int FlatID { get; set; }
        public Sell_Flat()
        {
            InitializeComponent();
        }

        public Sell_Flat(int FlatID,string LocationName,string buildingName,string FlatNo,string price)
        {
            InitializeComponent();
            this.FlatID = FlatID;
            lblLocationName.Text = LocationName;
            lblBuildingName.Text = buildingName;
            lblPrice.Text = price;
            lblFlatNo.Text = FlatNo;

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            ClientManager cm = new ClientManager();
            cm.FlatID = FlatID;
            cm.ClientName = txtClientName.Text;
            cm.ContactNo = txtContactNo.Text;
            cm.DepositAmount = Convert.ToInt64(txtDownpayment.Text);
            bool res = cm.sellFlatTo(cm);

            if (res)
            {
                MessageBox.Show("Flat Sold");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
