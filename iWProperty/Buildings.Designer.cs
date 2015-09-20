namespace iWProperty
{
    partial class Buildings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAddBuildingForm = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddBuilding = new System.Windows.Forms.Button();
            this.btnUpdateBuilding = new System.Windows.Forms.Button();
            this.txtBuildingDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPnlAddBuilding = new System.Windows.Forms.Button();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.pnlBuildingGrid = new System.Windows.Forms.Panel();
            this.BuildingGrid = new System.Windows.Forms.DataGridView();
            this.lblBuildingID = new System.Windows.Forms.Label();
            this.pnlAddBuildingForm.SuspendLayout();
            this.pnlBuildingGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddBuildingForm
            // 
            this.pnlAddBuildingForm.Controls.Add(this.btnCancel);
            this.pnlAddBuildingForm.Controls.Add(this.btnAddBuilding);
            this.pnlAddBuildingForm.Controls.Add(this.btnUpdateBuilding);
            this.pnlAddBuildingForm.Controls.Add(this.txtBuildingDescription);
            this.pnlAddBuildingForm.Controls.Add(this.label2);
            this.pnlAddBuildingForm.Controls.Add(this.txtBuildingName);
            this.pnlAddBuildingForm.Controls.Add(this.label1);
            this.pnlAddBuildingForm.Location = new System.Drawing.Point(265, 60);
            this.pnlAddBuildingForm.Name = "pnlAddBuildingForm";
            this.pnlAddBuildingForm.Size = new System.Drawing.Size(535, 382);
            this.pnlAddBuildingForm.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(132, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddBuilding
            // 
            this.btnAddBuilding.Location = new System.Drawing.Point(260, 228);
            this.btnAddBuilding.Name = "btnAddBuilding";
            this.btnAddBuilding.Size = new System.Drawing.Size(94, 41);
            this.btnAddBuilding.TabIndex = 4;
            this.btnAddBuilding.Text = "Add";
            this.btnAddBuilding.UseVisualStyleBackColor = true;
            this.btnAddBuilding.Click += new System.EventHandler(this.btnAddBuilding_Click);
            // 
            // btnUpdateBuilding
            // 
            this.btnUpdateBuilding.Location = new System.Drawing.Point(260, 228);
            this.btnUpdateBuilding.Name = "btnUpdateBuilding";
            this.btnUpdateBuilding.Size = new System.Drawing.Size(94, 41);
            this.btnUpdateBuilding.TabIndex = 5;
            this.btnUpdateBuilding.Text = "Update";
            this.btnUpdateBuilding.UseVisualStyleBackColor = true;
            this.btnUpdateBuilding.Visible = false;
            this.btnUpdateBuilding.Click += new System.EventHandler(this.btnUpdateBuilding_Click);
            // 
            // txtBuildingDescription
            // 
            this.txtBuildingDescription.Location = new System.Drawing.Point(260, 114);
            this.txtBuildingDescription.Name = "txtBuildingDescription";
            this.txtBuildingDescription.Size = new System.Drawing.Size(150, 20);
            this.txtBuildingDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(260, 68);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(150, 20);
            this.txtBuildingName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Building Name";
            // 
            // btnPnlAddBuilding
            // 
            this.btnPnlAddBuilding.Location = new System.Drawing.Point(882, 1);
            this.btnPnlAddBuilding.Name = "btnPnlAddBuilding";
            this.btnPnlAddBuilding.Size = new System.Drawing.Size(147, 37);
            this.btnPnlAddBuilding.TabIndex = 1;
            this.btnPnlAddBuilding.Text = "Add New Building";
            this.btnPnlAddBuilding.UseVisualStyleBackColor = true;
            this.btnPnlAddBuilding.Click += new System.EventHandler(this.btnPnlAddBuilding_Click);
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Location = new System.Drawing.Point(64, 13);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(0, 13);
            this.lblLocationName.TabIndex = 2;
            // 
            // pnlBuildingGrid
            // 
            this.pnlBuildingGrid.Controls.Add(this.BuildingGrid);
            this.pnlBuildingGrid.Location = new System.Drawing.Point(36, 44);
            this.pnlBuildingGrid.Name = "pnlBuildingGrid";
            this.pnlBuildingGrid.Size = new System.Drawing.Size(993, 412);
            this.pnlBuildingGrid.TabIndex = 3;
            // 
            // BuildingGrid
            // 
            this.BuildingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuildingGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuildingGrid.Location = new System.Drawing.Point(0, 0);
            this.BuildingGrid.Name = "BuildingGrid";
            this.BuildingGrid.Size = new System.Drawing.Size(993, 412);
            this.BuildingGrid.TabIndex = 0;
            this.BuildingGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BuildingGrid_CellContentClick);
            // 
            // lblBuildingID
            // 
            this.lblBuildingID.AutoSize = true;
            this.lblBuildingID.Location = new System.Drawing.Point(1036, 332);
            this.lblBuildingID.Name = "lblBuildingID";
            this.lblBuildingID.Size = new System.Drawing.Size(0, 13);
            this.lblBuildingID.TabIndex = 4;
            this.lblBuildingID.Visible = false;
            // 
            // Buildings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 468);
            this.Controls.Add(this.lblBuildingID);
            this.Controls.Add(this.pnlBuildingGrid);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.btnPnlAddBuilding);
            this.Controls.Add(this.pnlAddBuildingForm);
            this.Name = "Buildings";
            this.Text = "Bulidings";
            this.pnlAddBuildingForm.ResumeLayout(false);
            this.pnlAddBuildingForm.PerformLayout();
            this.pnlBuildingGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuildingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddBuildingForm;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuildingDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddBuilding;
        private System.Windows.Forms.Button btnUpdateBuilding;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPnlAddBuilding;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Panel pnlBuildingGrid;
        private System.Windows.Forms.DataGridView BuildingGrid;
        private System.Windows.Forms.Label lblBuildingID;
    }
}