﻿namespace iWProperty
{
    partial class SearchFlats
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
            this.label1 = new System.Windows.Forms.Label();
            this.LocationList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BuildingList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlatGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlatGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // LocationList
            // 
            this.LocationList.FormattingEnabled = true;
            this.LocationList.Location = new System.Drawing.Point(175, 20);
            this.LocationList.Name = "LocationList";
            this.LocationList.Size = new System.Drawing.Size(158, 21);
            this.LocationList.TabIndex = 1;
            this.LocationList.SelectedIndexChanged += new System.EventHandler(this.LocationList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Building";
            // 
            // BuildingList
            // 
            this.BuildingList.FormattingEnabled = true;
            this.BuildingList.Location = new System.Drawing.Point(522, 20);
            this.BuildingList.Name = "BuildingList";
            this.BuildingList.Size = new System.Drawing.Size(158, 21);
            this.BuildingList.TabIndex = 3;
            this.BuildingList.SelectedIndexChanged += new System.EventHandler(this.BuildingList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FlatGrid);
            this.panel1.Location = new System.Drawing.Point(29, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 321);
            this.panel1.TabIndex = 4;
            // 
            // FlatGrid
            // 
            this.FlatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlatGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlatGrid.Location = new System.Drawing.Point(0, 0);
            this.FlatGrid.Name = "FlatGrid";
            this.FlatGrid.Size = new System.Drawing.Size(961, 321);
            this.FlatGrid.TabIndex = 0;
            this.FlatGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlatGrid_CellContentClick);
            // 
            // SearchFlats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BuildingList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LocationList);
            this.Controls.Add(this.label1);
            this.Name = "SearchFlats";
            this.Text = "SearchFlats";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FlatGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LocationList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BuildingList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView FlatGrid;
    }
}