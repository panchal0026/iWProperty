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
    public partial class SearchFlats : Form
    {
        public SearchFlats()
        {
            InitializeComponent();
            bindLocation();
        }

        public void bindLocation() 
        {
            LocationManager ls = new LocationManager();
            DataSet ds = ls.ListLocations();
            if (ds.Tables[0].Rows.Count > 0)
            {

                LocationList.DisplayMember = "LocationName";
                LocationList.ValueMember = "id";
                LocationList.DataSource = ds.Tables[0];
            }
            else
            {
                //drpLocation.Items.Add()
            }
        }

        public void bindFlatGrid()
        {
            FlatManager f = new FlatManager();

            DataSet ds = f.ListUnsoldFlats(Convert.ToInt32(BuildingList.SelectedValue));

            if (ds.Tables[0].Rows.Count > 0)
            {
                FlatGrid.AutoGenerateColumns = false;
                FlatGrid.DataSource = null;
                //Set Columns Count 
                FlatGrid.ColumnCount = 3;

                //Add Columns
                FlatGrid.Columns[0].Name = "FlatID";
                FlatGrid.Columns[0].HeaderText = "FlatID";
                FlatGrid.Columns[0].DataPropertyName = "FlatID";

                FlatGrid.Columns[1].HeaderText = "FlatNo";
                FlatGrid.Columns[1].Name = "FlatNo";
                FlatGrid.Columns[1].DataPropertyName = "FlatNo";

                FlatGrid.Columns[2].Name = "Price";
                FlatGrid.Columns[2].HeaderText = "Price";
                FlatGrid.Columns[2].DataPropertyName = "Price";

                FlatGrid.DataSource = ds.Tables[0];

                //Buttons

                DataGridViewLinkColumn sell = new DataGridViewLinkColumn();
                sell.UseColumnTextForLinkValue = true;
                sell.HeaderText = "Sell";
                sell.DataPropertyName = "lnkForSellColumn";
                sell.LinkBehavior = LinkBehavior.SystemDefault;
                sell.Text = "Sell";
                FlatGrid.Columns.Add(sell);
            }

            else 
            {
                FlatGrid.Visible = false;
            }


        }

        private void LocationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int LocationID = Convert.ToInt32(LocationList.SelectedValue);
            bindBuildings(LocationID);
        }

        public void bindBuildings(int LocationID) 
        {
            BuildingManager b = new BuildingManager();
            DataSet ds =  b.listBuildingbyLocation(LocationID);
            if (ds.Tables[0].Rows.Count > 0)
            {

                BuildingList.DisplayMember = "BuildingName";
                BuildingList.ValueMember = "BuildingID";
                BuildingList.DataSource = ds.Tables[0];
            }
            else
            {
                //drpLocation.Items.Add()
            }
        }

        private void BuildingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlatGrid.DataSource = null;
            bindFlatGrid();
        }

        private void FlatGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int FlatID = Convert.ToInt32(FlatGrid.Rows[e.RowIndex].Cells["FlatID"].Value);
                string FlatNo = FlatGrid.Rows[e.RowIndex].Cells["FlatNo"].Value.ToString();
                string price = FlatGrid.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                string bname = BuildingList.SelectedText;
                string loc = LocationList.SelectedText;
                Sell_Flat b = new Sell_Flat(FlatID, loc, bname, FlatNo, price);
                b.Show();


            }
        }
    }
}
