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
    public partial class Flats : Form
    {
        public int BuildingID { get; set; }
        public Flats()
        {
            InitializeComponent();
        }

        public Flats(int BuildingID, string BuildingName)
        {
            InitializeComponent();
            this.BuildingID = BuildingID;
            lblBuildingName.Text = BuildingName;
            bindFlatGrid();
        }

        #region ControlEvents

        private void btnPnlAddFlat_Click(object sender, EventArgs e)
        {
            switchpnl(true);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFlat_Click(object sender, EventArgs e)
        {
            FlatManager f = new FlatManager();
            f.BuildingID = BuildingID;
            f.FlatNo = txtFlatNo.Text;
            f.Price = Convert.ToInt64(txtPrice.Text);
            f.DownPayment = 0;
            f.AmountPayed = 0;
            f.IsSelled = false;

            bool res = f.AddFlat(f);
            if (res)
            {
                MessageBox.Show("Record Inserted Successfully");
                bindFlatGrid();
                switchpnl(false);
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void FlatGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                //BuildingID = Convert.ToInt32(BuildingGrid.Rows[e.RowIndex].Cells["BuildingID"].Value);
                //string LocName = BuildingGrid.Rows[e.RowIndex].Cells["BuildingName"].Value.ToString();
                Sell_Flat b = new Sell_Flat();
                b.Show();


            }
        }

        #endregion

        #region Methods

        public void bindFlatGrid()
        {
            FlatManager f = new FlatManager();
            DataSet ds = f.ListFlats(BuildingID);

            if (ds.Tables[0].Rows.Count > 0)
            {
                FlatGrid.AutoGenerateColumns = false;
                FlatGrid.DataSource = null;
                //Set Columns Count 
                FlatGrid.ColumnCount = 3;

                //Add Columns
                FlatGrid.Columns[0].Name = "Id";
                FlatGrid.Columns[0].HeaderText = "Id";
                FlatGrid.Columns[0].DataPropertyName = "FlatID";

                FlatGrid.Columns[1].HeaderText = "FlatNo";
                FlatGrid.Columns[1].Name = "FlatNo";
                FlatGrid.Columns[1].DataPropertyName = "FlatNo";

                FlatGrid.Columns[2].Name = "Price";
                FlatGrid.Columns[2].HeaderText = "Price";
                FlatGrid.Columns[2].DataPropertyName = "Price";

                FlatGrid.DataSource = ds.Tables[0];

                //Buttons

                DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                Editlink.UseColumnTextForLinkValue = true;
                Editlink.HeaderText = "Edit";
                Editlink.DataPropertyName = "lnkForEditColumn";
                Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                Editlink.Text = "Edit";
                FlatGrid.Columns.Add(Editlink);

                DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                Deletelink.UseColumnTextForLinkValue = true;
                Deletelink.HeaderText = "delete";
                Deletelink.DataPropertyName = "lnkForDeleteColumn";
                Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                Deletelink.Text = "Delete";
                FlatGrid.Columns.Add(Deletelink);

                DataGridViewLinkColumn AddBuilding = new DataGridViewLinkColumn();
                AddBuilding.UseColumnTextForLinkValue = true;
                AddBuilding.HeaderText = "Sell";
                AddBuilding.DataPropertyName = "lnkForSellColumn";
                AddBuilding.LinkBehavior = LinkBehavior.SystemDefault;
                AddBuilding.Text = "Sell";
                FlatGrid.Columns.Add(AddBuilding);
            }


        }

        public void switchpnl(bool form)
        {
            if (form)
            {
                pnlFlatForm.Visible = true;
                pnlFlatGrid.Visible = false;
            }
            else
            {
                pnlFlatGrid.Visible = true;
                pnlFlatForm.Visible = false;
            }
        }
        #endregion

    
    }

}
