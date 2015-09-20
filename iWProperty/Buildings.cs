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
    public partial class Buildings : Form
    {
        public int LocationID { get; set; }
        public Buildings()
        {
            InitializeComponent();
        }

        public Buildings(int LocationID,string LocationName) 
        {
            InitializeComponent();
            this.LocationID = LocationID;
            lblLocationName.Text = LocationName;
            bindBuildingGrid();

        }

        #region ControlEvents

        private void btnUpdateBuilding_Click(object sender, EventArgs e)
        {
            BuildingManager building = new BuildingManager();
            building.BuildingID = Convert.ToInt32(lblBuildingID.Text);
            building.LocationID = LocationID;
            building.BuildingName = txtBuildingName.Text;
            building.BuildingDesc = txtBuildingDescription.Text;

            bool res = building.UpdateBuilding(building);
            if (res)
            {
                MessageBox.Show("Record Updated Successfully");
                bindBuildingGrid();
                switchpnl(false);
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnPnlAddBuilding_Click(object sender, EventArgs e)
        {
            pnlAddBuildingForm.Visible = true;
            pnlBuildingGrid.Visible = false;
        }

        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            BuildingManager building = new BuildingManager();
            building.LocationID = LocationID;
            building.BuildingName = txtBuildingName.Text;
            building.BuildingDesc = txtBuildingDescription.Text;

            bool res = building.AddNewBuilding(building);
            if (res)
            {
                MessageBox.Show("Record Inserted Successfully");
                bindBuildingGrid();
                switchpnl(false);
            }
            else 
            {
                MessageBox.Show("Error");
            }
        }

        private void BuildingGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int BuildingID = 0;

            if (e.ColumnIndex == 4)
            {

                txtBuildingName.Text = BuildingGrid.Rows[e.RowIndex].Cells["BuildingName"].Value.ToString();
                txtBuildingDescription.Text = BuildingGrid.Rows[e.RowIndex].Cells["BuildingDescription"].Value.ToString();
                lblBuildingID.Text = BuildingGrid.Rows[e.RowIndex].Cells["BuildingID"].Value.ToString();

                switchpnl(true);
                btnAddBuilding.Visible = false;
                btnUpdateBuilding.Visible = true;


            }
            //if (e.ColumnIndex == 4)
            //{
            //    location_id = Convert.ToInt32(LocationGrid.Rows[e.RowIndex].Cells["Id"].Value);

            //    LocationManager loc_manager = new LocationManager();
            //    loc_manager.DeleteLocation(location_id);
            //    bindLocation();

            //    pnlLocationForm.Visible = false;
            //    pnlLocationGrid.Visible = true;
            //}

            if (e.ColumnIndex == 5)
            {
                BuildingID = Convert.ToInt32(BuildingGrid.Rows[e.RowIndex].Cells["BuildingID"].Value);
                string LocName = BuildingGrid.Rows[e.RowIndex].Cells["BuildingName"].Value.ToString();
                Flats b = new Flats(BuildingID, LocName);
                b.Show();


            }
        }

        #endregion

        #region Methods

        public void switchpnl(bool form) 
        {
            if (form)
            {
                pnlAddBuildingForm.Visible = true;
                pnlBuildingGrid.Visible = false;
            }
            else 
            {
                pnlBuildingGrid.Visible = true;
                pnlAddBuildingForm.Visible = false;
            }
        }

        public void bindBuildingGrid()
        {
            BuildingManager b = new BuildingManager();
            DataSet ds = b.listBuildingbyLocation(LocationID);

            if (ds.Tables[0].Rows.Count > 0)
            {
                BuildingGrid.AutoGenerateColumns = false;
                BuildingGrid.DataSource = null;
                //Set Columns Count 
                BuildingGrid.ColumnCount = 3;

                //Add Columns
                BuildingGrid.Columns[0].Name = "BuildingID";
                BuildingGrid.Columns[0].HeaderText = "BuildingID";
                BuildingGrid.Columns[0].DataPropertyName = "BuildingID";

                BuildingGrid.Columns[1].HeaderText = "Building Name";
                BuildingGrid.Columns[1].Name = "BuildingName";
                BuildingGrid.Columns[1].DataPropertyName = "BuildingName";

                BuildingGrid.Columns[2].Name = "BuildingDescription";
                BuildingGrid.Columns[2].HeaderText = "Building Description";
                BuildingGrid.Columns[2].DataPropertyName = "BuildingDescription";

                BuildingGrid.DataSource = ds.Tables[0];

                //Buttons

                DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                Editlink.UseColumnTextForLinkValue = true;
                Editlink.HeaderText = "Edit";
                Editlink.DataPropertyName = "lnkForEditColumn";
                Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                Editlink.Text = "Edit";
                BuildingGrid.Columns.Add(Editlink);

                DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                Deletelink.UseColumnTextForLinkValue = true;
                Deletelink.HeaderText = "delete";
                Deletelink.DataPropertyName = "lnkForDeleteColumn";
                Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                Deletelink.Text = "Delete";
                BuildingGrid.Columns.Add(Deletelink);

                DataGridViewLinkColumn AddBuilding = new DataGridViewLinkColumn();
                AddBuilding.UseColumnTextForLinkValue = true;
                AddBuilding.HeaderText = "Add Flats";
                AddBuilding.DataPropertyName = "lnkForFlatsColumn";
                AddBuilding.LinkBehavior = LinkBehavior.SystemDefault;
                AddBuilding.Text = "Add Flats";
                BuildingGrid.Columns.Add(AddBuilding);

            }
        }
        
        #endregion

       
    }
}
